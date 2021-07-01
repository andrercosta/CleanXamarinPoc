using CleanXamarinPoc.App.Main.Factories.UseCases;
using CleanXamarinPoc.App.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Main.Factories.ViewModels
{
    public static class ProductViewModelFactory
    {
        public static ProductViewModel MakeProductViewModel()
        {
            return new ProductViewModel(GetProductsfactory.MakeGetAllProducts());
        }
    }
}
