using CatMS.Data;
using CatMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CatMS.Repositorys
{
    public class CatLikeRepository : ICatLikeRepository
    {
        private readonly ApplicationDbContext _context;
        public CatLikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<CatLike> AddLikeForBlog(CatLike catLike)
        {
            await _context.CatLikes.AddAsync(catLike);
            await _context.SaveChangesAsync();
            return catLike;
        }

        public async Task<IEnumerable<CatLike>> GetLikesForBlog(int catId)
        {
            return await _context.CatLikes.Where(x => x.CatId == catId).ToListAsync();
        }

        public async Task<int> GetTotalLikes(int catId)
        {
            return await _context.CatLikes.CountAsync(x => x.CatId == catId);

        }
    }
}
