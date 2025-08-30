using CatMS.Models;
using CatMS.Repositorys;
using Microsoft.AspNetCore.Mvc;


namespace CatMS.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class BuyerController : Controller
    {

        private readonly IBuyerRepository _buyerRepostory;
        public BuyerController(IBuyerRepository buyerRepostory)
        {
            _buyerRepostory = buyerRepostory;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _buyerRepostory.GetAllCatsAsync();
            return View(data);
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrEdit(int id)
        {
            if (id == null)
            {
                return View(new Buyer());
            }
            else
            {
                var data = await _buyerRepostory.GetCatByIdAsync(id);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(Buyer buyer)
        {
            if (buyer.Id == 0)
            {
                await _buyerRepostory.AddCatAsync(buyer);
                return RedirectToAction("Index");
            }
            else
            {
                await _buyerRepostory.UpdateCatAsync(buyer);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _buyerRepostory.GetCatByIdAsync(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _buyerRepostory.DeleteCatAsync(id);
            if (data != null)
            {
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
