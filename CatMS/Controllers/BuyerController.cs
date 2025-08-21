using CatMS.Models;
using CatMS.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace CatMS.Controllers
{
    public class BuyerController : Controller
    {
        private readonly IBuyerRepository _buyerRepository;
        public BuyerController(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _buyerRepository.GetAllCatsAsync();
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
                var data = await _buyerRepository.GetCatByIdAsync(id);
                return View(data);
            }
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(Buyer buyer)
        {
            if (buyer.Id == 0)
            {
                await _buyerRepository.AddCatAsync(buyer);
                return RedirectToAction("Index");
            }
            else
            {
                await _buyerRepository.UpdateCatAsync(buyer);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _buyerRepository.GetCatByIdAsync(id);
            if (data != null)
            {
                return View(data);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _buyerRepository.DeleteCatAsync(id);
            if (data != null)
            {
                return RedirectToAction("Index");
            }
            return NotFound();
        }
    }
}
