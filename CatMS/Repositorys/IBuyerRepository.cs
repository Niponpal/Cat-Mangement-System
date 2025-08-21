using CatMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatMS.Repositorys
{
    public interface IBuyerRepository
    {
        Task<IEnumerable<Buyer>> GetAllCatsAsync();
        Task<Buyer> GetCatByIdAsync(int id);
        Task<Buyer> AddCatAsync(Buyer buyer);
        Task<Buyer> UpdateCatAsync(Buyer buyer);
        Task<Buyer> DeleteCatAsync(int id);
       
    }
}
