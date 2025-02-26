using Infra.Entities;

namespace Infra.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers(string userName);
    }
}