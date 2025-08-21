using CatMS.Data;
using CatMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CatMS.Repositorys
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly ApplicationDbContext _context;
        public BuyerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Buyer> AddCatAsync(Buyer buyer)
        {
            await _context.Buyers.AddAsync(buyer);
            await _context.SaveChangesAsync();
            return buyer;
        }

        public async Task<Buyer> DeleteCatAsync(int id)
        {
            var data = await _context.Buyers.FindAsync(id);
            if (data != null)
            {
                _context.Buyers.Remove(data);
                await _context.SaveChangesAsync();
                return data;
            }
            return null;
        }

      

        public async Task<IEnumerable<Buyer>> GetAllCatsAsync()
        {
            var data = await _context.Buyers.ToListAsync();
            return data;
        }

        public async Task<Buyer> GetCatByIdAsync(int id)
        {
            var data = await _context.Buyers.FindAsync(id);
            if (data != null)
            {
                return data;
            }
            return null;
        }

        public async Task<Buyer> UpdateCatAsync(Buyer buyer)
        {
            var data = await _context.Buyers.FindAsync(buyer.Id);
            if (data != null)
            {
                data.FullName = buyer.FullName;
                data.Email = buyer.Email;
                data.Phone = buyer.Phone;
                data.Address = buyer.Address;
                data.RegisterDate = buyer.RegisterDate;
                _context.Buyers.Update(data);
                await _context.SaveChangesAsync();
                return data;
            }
            return null;

        }
    }
}
