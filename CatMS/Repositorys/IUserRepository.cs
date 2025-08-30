using Microsoft.AspNetCore.Identity;

namespace CatMS.Repositorys
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
