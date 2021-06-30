using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanXamarinPoc.App.Data.Http
{
    public interface IHttpClient
    {
        Task<T> Request<T>(string url, string method, object body = null);
    }
}
