using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using tecweb2.webapi.Extensions;
using tecweb2.webapi.Helpers.Exceptions;
using tecweb2.webapi.Models.Entities;
using tecweb2.webapi.Models.Payload;
using tecweb2.webapi.Models.Proxy;
using tecweb2.webapi.Repositories.Interfaces;

namespace tecweb2.webapi.Businesses
{
    public class AuthBusiness
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IConfiguration _configuration;

        public AuthBusiness(IUsersRepository usersRepository, IConfiguration configuration)
        {
            _usersRepository = usersRepository;
            _configuration = configuration;
        }

        public async Task<TokenProxy> Login(LoginPayload payload)
        {
            var userEntity = await _usersRepository.GetByLogin(payload.Username);

            if (userEntity == null)
                throw new InvalidArgumentException("Usuário ou senha inválidos!",
                    (int) ExceptionEnum.NotFound);

            if (userEntity.Password != payload.Password.CalculateMd5Hash())
                throw new InvalidArgumentException("Usuário ou senha inválidos!",
                    (int) ExceptionEnum.NotFound);

            var jwtToken = JwtSecurityToken(userEntity);

            var tokenProxy = CreateTokenProxy(jwtToken);

            return tokenProxy;
        }

        private static TokenProxy CreateTokenProxy(JwtSecurityToken jwtToken)
        {
            var tokenProxy = new TokenProxy
            {
                Token = $"Bearer {new JwtSecurityTokenHandler().WriteToken(jwtToken)}",
                ExpirationDate = jwtToken.ValidTo
            };
            return tokenProxy;
        }

        private JwtSecurityToken JwtSecurityToken(UserEntity userEntity)
        {
            var jwtToken = new JwtSecurityToken(
                _configuration["SiteUrl"],
                _configuration["SiteUrl"],
                GetTokenClaims(userEntity),
                expires: DateTime.UtcNow.AddMonths(6),
                signingCredentials: new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtKey"])),
                    SecurityAlgorithms.HmacSha256)
            );
            return jwtToken;
        }

        private static IEnumerable<Claim> GetTokenClaims(UserEntity user)
        {
            var values = new List<Claim> {new Claim(ClaimTypes.Name, user.Id.ToString())};
            values.AddRange(user.Roles.Split('|').Select(role => new Claim(ClaimTypes.Role, role)));
            return values;
        }
    }
}