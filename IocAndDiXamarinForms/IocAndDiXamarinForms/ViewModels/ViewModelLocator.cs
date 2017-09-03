using Microsoft.Practices.ServiceLocation;

namespace IocAndDiXamarinForms.ViewModels
{
    public class ViewModelLocator
    {
        public ProductsViewModel ProductsViewModel
        {
            get { return ServiceLocator.Current.GetInstance<ProductsViewModel>(); }
        }
    }
}
