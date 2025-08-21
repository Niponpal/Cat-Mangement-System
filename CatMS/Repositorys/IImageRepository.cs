namespace CatMS.Repositorys
{
    public interface IImageRepository
    {
        Task<string> UploadAsync(IFormFile file);
    }
}
