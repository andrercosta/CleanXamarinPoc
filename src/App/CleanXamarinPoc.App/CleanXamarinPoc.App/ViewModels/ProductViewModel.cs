using CleanXamarinPoc.App.Domain.UseCases;
using CleanXamarinPoc.App.Views.Product.DTOs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace CleanXamarinPoc.App.ViewModels
{
    public class ProductViewModel
    {
        private readonly IGetAllProducts getProducts;

        public ObservableCollection<GetProductsItemsDTO> Products { get; set; }

        public ProductViewModel(IGetAllProducts getProducts)
        {
            this.getProducts = getProducts;
        }

        public async Task OnInitialized()
        {
            await LoadProducts();
        }

        private async Task LoadProducts()
        {
            var entities = await getProducts.GetAllProducts();
            Products = new ObservableCollection<GetProductsItemsDTO>(entities.Select(GetProductsItemsDTO.FromEntity).ToList());
        }
    }
}
