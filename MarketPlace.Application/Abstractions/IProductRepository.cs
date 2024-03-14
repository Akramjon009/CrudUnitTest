using MarketPlace.Domain.Entities;

namespace MarketPlace.Application.Abstractions
{
    public interface IProductRepository
    {
        public ValueTask<List<Product>> GetAllAsync();
        public ValueTask<Product> GetByIdAsync(int id);
        public ValueTask<Product> InsertAsync(Product pr);
        public ValueTask<Product> DeleteAsync(Product pr);
        public ValueTask<Product> UpdateAsync(Product pr);
    }
}
