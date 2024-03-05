using Microsoft.EntityFrameworkCore;
using ShopManager.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManager.Data.Concrete
{
    public class EFProductRepository : IProductRepository, IDisposable
    {
        private readonly string _connectionString;
        private readonly StoreDbContext _context;

        public EFProductRepository(string connectionString)
        {
            _connectionString = connectionString;
            _context = new StoreDbContext(_connectionString);
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public Task DeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable<Product> GetAllProductsAsync()
        {
            using (var context = new StoreDbContext(_connectionString))
            {
                return context.Products.AsQueryable();
            }
        }

        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
