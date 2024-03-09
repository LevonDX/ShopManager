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
        private readonly StoreDbContext _context;

        public EFProductRepository(StoreDbContext dbContext)
        {
            _context = dbContext;
        }

        public async Task AddProductAsync(Product product)
        {
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
           Product? pToDelete = await _context.Products.FindAsync(id);

            if (pToDelete == null)
            {
                throw new InvalidOperationException("Product not found");
            }

            _context.Products.Remove(pToDelete);

            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IQueryable<Product> GetAllProductsAsync()
        {
            return _context.Products.AsQueryable();
        }

        public async Task<Product?> GetProductByIdAsync(int id)
        {
            Product? product = await _context.Products.FindAsync(id);

            return product;
        }

        public async Task UpdateProductAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
