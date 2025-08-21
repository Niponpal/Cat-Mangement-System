using CatMS.Models;
using CatMS.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace CatMS.Controllers
{
    public class CatController : Controller
    {
        private readonly ICatRepository _catRepository;
        public CatController(ICatRepository catRepository)
        {
            _catRepository = catRepository;
        }
        public async Task<IActionResult> Index()
        {
            var cats = await _catRepository.GetAllCatsAsync();
            return View(cats);
        }
        [HttpGet]
        public async Task<IActionResult> CreateOrEdit(int id)
        {
            if (id == 0)
            {
                return View(new Cat());
            }
            var data = await _catRepository.GetCatByIdAsync(id);
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> CreateOrEdit(Cat cat)
        {
            if (cat.Id == 0)
            {
                await _catRepository.AddCatAsync(cat);
                return RedirectToAction("Index");
            }
            else
            {
                await _catRepository.UpdateCatAsync(cat);
                return RedirectToAction("Index");
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _catRepository.GetCatByIdAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return View(data);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var data = await _catRepository.DeleteCatAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            return RedirectToAction("Index");
        }
    }
}
