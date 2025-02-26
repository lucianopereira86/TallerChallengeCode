using Infra.Database;
using Infra.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Interfaces
{
    public class UserRepository : IUserRepository
    {

        public async Task<List<User>> GetUsers(string userName)
        {
            using var db = new ApplicationDbContext();
            return await db.Users.Where(w => w.UserName == userName).ToListAsync();
        }
    }
}
