using MarketPlace.Domain.Entities;
using Moq;

namespace MarketPlace.Test
{
    public partial class ProductServiceLogic : ProductServiceTests
    {

        [Fact]
        public async Task AddNewProductAsync()
        {

            //Arrange
            var inputProduct = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "zo'r narsa"
            };
            var expectedProduct = new Product()
            {
                Id = inputProduct.Id,
                Name = inputProduct.Name,
                Description = inputProduct.Description
            };

            //Act
            _productRepoMock.Setup(p => p.InsertAsync(It.IsAny<Product>()))
                //=>x.AddAsync(inputProduct))
                .ReturnsAsync(expectedProduct);

            var actualProduct = await _productService.Add(inputProduct);

            //Assert
            Assert.Equal(expectedProduct.Name, actualProduct.Name);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
        }

        [Fact]
        public async Task DeleteNewProductAsync()
        {

            //Arrange
            var inputProduct = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "zo'r narsa"
            };
            var expectedProduct = new Product()
            {
                Id = inputProduct.Id,
                Name = inputProduct.Name,
                Description = inputProduct.Description
            };

            //Act
            _productRepoMock.Setup(p => p.DeleteAsync(It.IsAny<Product>()))
                // => p.DeleteAsync(it.IsAny<Product>()))
                .ReturnsAsync(expectedProduct);

            var actualProduct = await _productService.Delete(inputProduct.Id);

            //Assert
            Assert.Equal(expectedProduct.Name, actualProduct.Name);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
        }

        public async Task UpdateNewProductAsync()
        {

            //Arrange
            var inputProduct = new Product()
            {
                Id = 1,
                Name = "Test",
                Description = "zo'r narsa"
            };
            var expectedProduct = new Product()
            {
                Id = inputProduct.Id,
                Name = inputProduct.Name,
                Description = inputProduct.Description
            };

            //Act
            _productRepoMock.Setup(p => p.UpdateAsync(It.IsAny<Product>()))
                // => p.DeleteAsync(it.IsAny<Product>()))
                .ReturnsAsync(expectedProduct);

            var actualProduct = await _productService.Update(inputProduct.Id, inputProduct);

            //Assert
            Assert.Equal(expectedProduct.Name, actualProduct.Name);
            Assert.Equal(expectedProduct.Description, actualProduct.Description);
        }
    }
}
