using IocAndDiXamarinForms.Interfaces;
using IocAndDiXamarinForms.Models;
using System.Collections.Generic;

namespace IocAndDiXamarinForms.Services
{
    public class ProductsService : IProductsService
    {
        public IEnumerable<Product> Getproducts()
        {
            return new List<Product>
            {
                new Product { Name = "Surface Laptop", Price = 1500 },
                new Product { Name = "XBox One", Price = 400 },
            };
        }
    }
}
