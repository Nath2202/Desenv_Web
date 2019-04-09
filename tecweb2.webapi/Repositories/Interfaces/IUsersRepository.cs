using System.Threading.Tasks;
using tecweb2.webapi.Models.Entities;
using tecweb2.webapi.Repositories.Base;

namespace tecweb2.webapi.Repositories.Interfaces
{
    public interface IUsersRepository : IBaseRepository<UserEntity>
    {
        Task<UserEntity> GetByLogin(string username);
    }
}