using IocAndDiXamarinForms.Models;
using IocAndDiXamarinForms.Services;
using System.Collections.Generic;
using IocAndDiXamarinForms.Interfaces;

namespace IocAndDiXamarinForms.ViewModels
{
    public class ProductsViewModel
    {
        private readonly IProductsService _productsService;
        public IEnumerable<Product> Products { get; set; }
        public ProductsViewModel(IProductsService productsService)
        {
            _productsService = productsService;
            DownloadProducts();
        }
        public void DownloadProducts()
        {
            Products = _productsService.Getproducts();
        }
    }
}
