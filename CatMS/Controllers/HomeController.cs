using CatMS.Models;
using CatMS.Repositorys;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CatMS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISellerRepostory _catPostRepository;
        private readonly ISellerRepostory _sellerRepository;

        public HomeController(ILogger<HomeController> logger, ISellerRepostory catPostRepository, ISellerRepostory sellerRepository)
        {
            _logger = logger;
            _catPostRepository = catPostRepository;
            _sellerRepository = sellerRepository;
          
        }

        public async Task<IActionResult> Index(IEnumerable<Cat> cat)
        {
            var model = await _sellerRepository.GetHomePageData();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public override bool Equals(object? obj)
        {
            return obj is HomeController controller &&
                   EqualityComparer<ILogger<HomeController>>.Default.Equals(_logger, controller._logger) &&
                   EqualityComparer<ISellerRepostory>.Default.Equals(_catPostRepository, controller._catPostRepository) &&
                   EqualityComparer<ISellerRepostory>.Default.Equals(_sellerRepository, controller._sellerRepository);
        }
    }

}
