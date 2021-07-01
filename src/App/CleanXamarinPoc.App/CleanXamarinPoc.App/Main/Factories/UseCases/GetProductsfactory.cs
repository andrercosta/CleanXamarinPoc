using CleanXamarinPoc.App.Data.UseCases;
using CleanXamarinPoc.App.Domain.UseCases;
using CleanXamarinPoc.App.Main.Factories.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Main.Factories.UseCases
{
    public static class GetProductsfactory
    {
        public static IGetAllProducts MakeGetAllProducts()
        {
            return new RemoteGetAllProducts(HttpClientFactory.MakeHttpClient(), ApiUrlFactory.MakeApiUrl("Products"));
        }
    }
}
