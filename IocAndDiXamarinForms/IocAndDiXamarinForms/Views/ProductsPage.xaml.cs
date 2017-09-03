using IocAndDiXamarinForms.ViewModels;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IocAndDiXamarinForms.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        public ProductsPage()
        {
            InitializeComponent();
            //BindingContext = ServiceLocator.Current.GetInstance(typeof(ProductsViewModel));
        }
    }
}