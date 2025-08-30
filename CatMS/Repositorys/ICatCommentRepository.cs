using CatMS.Models;
using System.Threading.Tasks;

namespace CatMS.Repositorys
{
    public interface ICatCommentRepository
    {
        Task<CatComment> AddAsync(CatComment comment);
        Task<IEnumerable<CatComment>> GetCommentsByBlogIdAsync(int cattId);
    }
}
