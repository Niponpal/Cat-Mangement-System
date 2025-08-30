using CatMS.Models;

namespace CatMS.Repositorys
{
    public interface ICatRepository
    {
        Task<IEnumerable<Cat>> GetAllCatsAsync();
        Task<Cat> GetCatByIdAsync(int id);
        Task<Cat> AddCatAsync(Cat cat);
        Task<Cat> UpdateCatAsync(Cat cat);
        Task<Cat> DeleteCatAsync(int id);
        Task<Cat> GetByUrlHandleAsync(string urlHandle);
    }
}
