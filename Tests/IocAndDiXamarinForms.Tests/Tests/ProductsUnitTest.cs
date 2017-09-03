using IocAndDiXamarinForms.Interfaces;
using IocAndDiXamarinForms.Services;
using IocAndDiXamarinForms.Tests.Mocks;
using IocAndDiXamarinForms.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IocAndDiXamarinForms.Tests.Tests
{
    [TestClass]
    public class ProductsUnitTest
    {
        [TestMethod]
        public void GetProductsTest()
        {
            // Arrange
            IProductsService productsService = new ProductsService();
            ITextToSpeech mockTextToSpeech = new MockTextToSpeach();
            var vm = new ProductsViewModel(productsService, mockTextToSpeech);

            // Act
            vm.DownloadProducts();

            // Assert
            var expected = productsService.Getproducts();
            var actual = vm.Products;
            Assert.AreEqual(expected, actual);
        }
    }
}
