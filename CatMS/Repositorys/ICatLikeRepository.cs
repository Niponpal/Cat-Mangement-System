using CatMS.Models;

namespace CatMS.Repositorys
{
    public interface ICatLikeRepository
    {
        Task<int> GetTotalLikes(int catId);
        Task<IEnumerable<CatLike>> GetLikesForBlog(int catId);
        Task<CatLike> AddLikeForBlog(CatLike catLike);

    }
}
