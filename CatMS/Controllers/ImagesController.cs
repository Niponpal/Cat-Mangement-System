using CatMS.Repositorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace CatMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository _imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            _imageRepository = imageRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("This is the get images api");
        }
        [HttpPost]
        public async Task<IActionResult> UploadAsync(IFormFile file)
        {
            // call a repository 
            var imageURL = _imageRepository.UploadAsync(file);
            if (imageURL is null)
            {
                return Problem("Something Went Wrong", null, (int)(HttpStatusCode.InternalServerError));
            }
            return new JsonResult(new { link = imageURL });
        }
    }
}

