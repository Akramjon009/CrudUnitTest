using MarketPlace.Application.Abstractions;
using MarketPlace.Domain.Entities;
using MarketPlace.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace MarketPlace.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MpDbContext _mpDbContext;

        public ProductRepository(MpDbContext mpDbContext)
        {
            _mpDbContext = mpDbContext;
        }

        public async ValueTask<Product> InsertAsync(Product pr)
        {
            var entry = await _mpDbContext.Products.AddAsync(pr);
            await _mpDbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<List<Product>> GetAllAsync()
        {
            return await _mpDbContext.Products.ToListAsync();
        }

        public async ValueTask<Product> GetByIdAsync(int id)
        {
            var res = await _mpDbContext.Products.FindAsync(id);
            return res;
        }

        public async ValueTask<Product> DeleteAsync(Product pr)
        {

            EntityEntry<Product>? entry = _mpDbContext.Products.Remove(pr);
            await _mpDbContext.SaveChangesAsync();

            return entry.Entity;
        }

        public async ValueTask<Product> UpdateAsync(Product product)
        {
            EntityEntry<Product>? entry = _mpDbContext.Products.Update(product);
            await _mpDbContext.SaveChangesAsync();

            return entry.Entity;
        }
    }
}
