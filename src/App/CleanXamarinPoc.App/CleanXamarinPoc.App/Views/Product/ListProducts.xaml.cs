using CleanXamarinPoc.App.Main.Factories.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CleanXamarinPoc.App.Views.Product
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListProducts : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public ListProducts()
        {
            InitializeComponent();

            BindingContext = ProductViewModelFactory.MakeProductViewModel();


        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
          
        }
    }
}
