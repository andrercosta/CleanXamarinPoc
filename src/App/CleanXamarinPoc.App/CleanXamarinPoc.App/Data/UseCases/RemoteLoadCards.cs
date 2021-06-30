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
    public class RemoteLoadCards : ILoadCards
    {
        private readonly IHttpClient httpClient;
        private readonly string url;

        public RemoteLoadCards(IHttpClient httpClient, string url)
        {
            this.httpClient = httpClient;
            this.url = url;
        }

        public async Task<IEnumerable<CardEntity>> LoadCards()
        {
            try
            {
                var httpResponse = await httpClient.Request<LoadCardsRemoteModel>(url, "GET");
                return httpResponse.ToListEntity();
            }
            catch (Exception ex)
            {
                throw new HttpServerErrorExeption(ex.Message);
            }
        }
    }
}
