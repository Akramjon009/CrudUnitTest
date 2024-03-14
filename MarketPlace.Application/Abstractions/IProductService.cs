using MarketPlace.Domain.Entities;

namespace MarketPlace.Application.Abstractions
{
    public interface IProductService
    {
        public ValueTask<List<Product>> GetAll();
        public ValueTask<Product> Get(int id);
        public ValueTask<Product> Add(Product pr);
        public ValueTask<Product> Delete(int id);
        public ValueTask<Product> Update(int id, Product product);
    }
}
