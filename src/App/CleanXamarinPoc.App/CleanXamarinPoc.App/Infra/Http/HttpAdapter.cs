using CleanXamarinPoc.App.Data.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CleanXamarinPoc.App.Infra.Http
{
    public class HttpAdapter : IHttpClient
    {
        private readonly HttpClient client;

        public HttpAdapter(HttpClient _client)
        {
            _client = client;
        }
        public async Task<T> Request<T>(string url, string method, object body = null)
        {
            HttpResponseMessage responseMessage = new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError);
            try
            {

                if (method == "GET")
                {
                    responseMessage = await client.GetAsync(url);
                }
                else if (method == "POST")
                {
                    var json = JsonConvert.SerializeObject(body);

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    responseMessage = await client.PostAsync(url, content);
                }
            }
            catch (Exception ex)
            {
                throw new HttpServerErrorExeption(ex.Message);
            }

            return await HandleResponse<T>(responseMessage);
        }

        private async Task<T> HandleResponse<T>(HttpResponseMessage response)
        {
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    var data = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(data);
                case System.Net.HttpStatusCode.BadRequest:
                    throw new HttpServerErrorExeption("");
                case System.Net.HttpStatusCode.NotFound:
                    throw new NotFoundErrorExeption();
                case System.Net.HttpStatusCode.InternalServerError:
                    throw new HttpServerErrorExeption("");
                default:
                    throw new HttpServerErrorExeption("");
            }
        }
    }
}
