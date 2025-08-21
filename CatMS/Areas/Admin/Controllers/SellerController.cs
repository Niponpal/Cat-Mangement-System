using CatMS.Data;
using CatMS.Models;
using CatMS.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace CatMS.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SellerController : Controller
    {
        private readonly ISellerRepostory _sellerRepostory;

        public SellerController(ISellerRepostory applicationDb)
        {
            _sellerRepostory = applicationDb;
        }
        public async Task<IActionResult> Index()
        {
            var data= await _sellerRepostory.GetAllSellersAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new Seller());
            }
            else
            {
                var data = await _sellerRepostory.GetSellerByIdAsync(id);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(Seller seller)
        {
            if (seller.Id == 0)
            {

                await _sellerRepostory.AddSellerAsync(seller);
                return RedirectToAction("Index"); 
            }
            else
            {
                await _sellerRepostory.UpdateSellerAsync(seller);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _sellerRepostory.GetSellerByIdAsync(id);
            if(data == null)
            {
                return NotFound();
            }
            return View (data);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _sellerRepostory.DeleteSellerAsync(id);
            if (data != null)
            {
                return View(data);
            }
            return RedirectToAction("Index");
        }
    }
}
