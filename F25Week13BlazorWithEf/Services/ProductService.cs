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
    }
}
