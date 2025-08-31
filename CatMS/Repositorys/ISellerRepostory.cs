using CatMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CatMS.Repositorys
{
    public interface ISellerRepostory
    {
        Task<IEnumerable<Seller>> GetAllSellersAsync();
        Task<Seller> AddSellerAsync(Seller seller);
        Task<Seller> UpdateSellerAsync(Seller seller);
        Task<Seller> DeleteSellerAsync(int id);
        Task<Seller> GetSellerByIdAsync(int id);
        Task<List<HomeViewModel>> GetHomePageData();

        IEnumerable<SelectListItem> Dropdown();

    }
}
