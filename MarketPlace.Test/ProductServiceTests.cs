using MarketPlace.Application.Abstractions;
using MarketPlace.Application.Services;
using Moq;

namespace MarketPlace.Test
{
    public partial class ProductServiceTests
    {
        public IProductService _productService;
        public Mock<IProductRepository> _productRepoMock;

        public ProductServiceTests()
        {
            _productRepoMock = new Mock<IProductRepository>();
            _productService = new ProductService(_productRepoMock.Object);
        }
    }
}
