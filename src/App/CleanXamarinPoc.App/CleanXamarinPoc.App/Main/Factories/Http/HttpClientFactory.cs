using CleanXamarinPoc.App.Data.Http;
using CleanXamarinPoc.App.Infra.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Main.Factories.Http
{
    public static class HttpClientFactory
    {
        public static IHttpClient MakeHttpClient()
        {
            return new HttpAdapter(new System.Net.Http.HttpClient());
        }
    }
}
