using CatMS.Data;
using CatMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CatMS.Repositorys
{
    public class CatCommentRepository : ICatCommentRepository
    {
        private readonly ApplicationDbContext _context;
        public CatCommentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CatComment> AddAsync(CatComment comment)
        {
            await _context.AddAsync(comment);
            await _context.SaveChangesAsync();
            return comment;
        }



        public async Task<IEnumerable<CatComment>> GetCommentsByBlogIdAsync(int cattId)
        {
            var data = await _context.CatComments.Where(x => x.CattId == cattId).ToListAsync();
            return data;
        }
    }
}
