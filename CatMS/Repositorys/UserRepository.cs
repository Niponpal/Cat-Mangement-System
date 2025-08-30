using CatMS.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CatMS.Repositorys
{
    public class UserRepository : IUserRepository
    {
        private readonly AuthDbContext _context;
        public UserRepository(AuthDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<IdentityUser>> GetAll()
        {
            var users = await _context.Users.ToListAsync();
            var superAdmin = await _context.Users.FirstOrDefaultAsync(x => x.Email == "superadmin@bloggie.com");
            if (superAdmin != null)
            {
                users.Remove(superAdmin);
            }
            return users;
        }
    }
}
