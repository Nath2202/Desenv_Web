using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tecweb2.webapi.Contexts;
using tecweb2.webapi.Models.Entities;
using tecweb2.webapi.Repositories.Base;
using tecweb2.webapi.Repositories.Interfaces;

namespace Data.Repositories.MySqlRepository
{
    public class UsersRepository : BaseRepository<SqlContext, UserEntity>, IUsersRepository
    {
        public UsersRepository(SqlContext context) : base(context, context.Users)
        {
        }

        public async Task<UserEntity> GetByLogin(string username)
            => await _context.Set<UserEntity>().FirstOrDefaultAsync(f => f.Username == username && f.Active);

    }
}