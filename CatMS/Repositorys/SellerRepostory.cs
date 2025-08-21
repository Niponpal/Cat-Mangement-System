using CatMS.Data;
using CatMS.Models;
using Microsoft.EntityFrameworkCore;

namespace CatMS.Repositorys
{
    public class SellerRepostory : ISellerRepostory
    {
        private readonly ApplicationDbContext _context;
        public SellerRepostory(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Seller> AddSellerAsync(Seller seller)
        {
              await _context.Sellers.AddAsync(seller);
              await _context.SaveChangesAsync();
              return seller;

        }

        public async Task<Seller> DeleteSellerAsync(int id)
        {
           var data = await _context.Sellers.FindAsync(id);
            if (data != null)
            {
                _context.Sellers.Remove(data);
                await _context.SaveChangesAsync();
                return data;
            }
            return null;
        }

        public async Task<IEnumerable<Seller>> GetAllSellersAsync()
        {
           var data = await _context.Sellers.ToListAsync();
            return data;
        }

        public async Task<Seller> GetSellerByIdAsync(int id)
        {
           var data = await _context.Sellers.FindAsync(id);
            if (data != null)
            {
                return data;
            }
            return null;
        }

        public async Task<Seller> UpdateSellerAsync(Seller seller)
        {
            var data = await _context.Sellers.FindAsync(seller.Id);
            if (data != null)
            {
                data.FullName = seller.FullName;
                data.Address = seller.Address;
                data.Phone = seller.Phone;
                data.Email = seller.Email;
                data.JoinDate=seller.JoinDate;
                _context.Update(data);
                await _context.SaveChangesAsync();
                return data;
            }
            return null;
        }
    }
}
