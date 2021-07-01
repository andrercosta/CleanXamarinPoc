using CleanXamarinPoc.App.Data.Http;
using CleanXamarinPoc.App.Data.Models;
using CleanXamarinPoc.App.Domain.Entities;
using CleanXamarinPoc.App.Domain.UseCases;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanXamarinPoc.App.Data.UseCases
{
    public class RemoteGetAllProducts : IGetAllProducts
    {
        private readonly IHttpClient httpClient;
        private readonly string url;

        public RemoteGetAllProducts(IHttpClient httpClient, string url)
        {
            this.httpClient = httpClient;
            this.url = url;
        }
        public async Task<IList<ProductEntity>> GetAllProducts()
        {
            try
            {
                IEnumerable<GetAllProductsModel> httpResponse = await httpClient.Request<IEnumerable<GetAllProductsModel>>(url, "GET");

                return GetAllProductsModel.ToListEntity(httpResponse);
            }
            catch (Exception ex)
            {
                throw new HttpServerErrorExeption(ex.Message);
            }
        }
    }
}
