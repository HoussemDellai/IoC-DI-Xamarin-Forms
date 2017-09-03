using System.Collections.Generic;
using IocAndDiXamarinForms.Models;

namespace IocAndDiXamarinForms.Interfaces
{
    public interface IProductsService
    {
        IEnumerable<Product> Getproducts();
    }
}