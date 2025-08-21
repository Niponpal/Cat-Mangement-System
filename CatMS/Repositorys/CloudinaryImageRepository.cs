using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System.Net;

namespace CatMS.Repositorys
{
    public class CloudinaryImageRepository: IImageRepository
    { 
        private readonly IConfiguration _configuration; // read this 
        private readonly Account account;

        public CloudinaryImageRepository(IConfiguration configuration)
        {
            _configuration = configuration;
            account = new Account(
                _configuration.GetSection("Cloudinary")["CloudName"],
                _configuration.GetSection("Cloudinary")["ApiKey"],
                _configuration.GetSection("Cloudinary")["ApiSecret"]
                );
        }
        public async Task<string> UploadAsync(IFormFile file)
        {
            var client = new Cloudinary(account);
            var uploadParams = new ImageUploadParams()
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
                DisplayName = file.FileName,
            };
            var uploadResult = await client.UploadAsync(uploadParams);
            if (uploadResult != null && uploadResult.StatusCode == HttpStatusCode.OK)
            {
                return uploadResult.SecureUri.ToString();
            }
            return null;
        }
    }
}
