using IocAndDiXamarinForms.Models;
using System.Collections.Generic;
using IocAndDiXamarinForms.Interfaces;

namespace IocAndDiXamarinForms.ViewModels
{
    public class ProductsViewModel
    {
        private readonly IProductsService _productsService;
        private readonly ITextToSpeech _textToSpeech;
        public IEnumerable<Product> Products { get; set; }
        public ProductsViewModel(IProductsService productsService, ITextToSpeech textToSpeech)
        {
            _productsService = productsService;
            _textToSpeech = textToSpeech;
            DownloadProducts();
            _textToSpeech.Speak("IoC and DI");
        }
        public void DownloadProducts()
        {
            Products = _productsService.Getproducts();
        }
    }
}
