using Microsoft.EntityFrameworkCore;
using F25Week13BlazorWithEf.Models;
using F25Week13BlazorWithEf.Data;

namespace F25Week13BlazorWithEf.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task AddAsync(Product prod)
        {
            _context.Products.Add(prod);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Product prod)
        {
            _context.Products.Update(prod);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var p = await _context.Products.FindAsync(id);

            if (p != null)
            {
                _context.Products.Remove(p);
                await _context.SaveChangesAsync();
            }
        }
    }
}
