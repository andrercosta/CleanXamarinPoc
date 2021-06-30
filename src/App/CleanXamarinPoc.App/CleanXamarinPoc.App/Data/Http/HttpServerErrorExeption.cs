using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Data.Http
{
    public class HttpServerErrorExeption : Exception
    {
        public HttpServerErrorExeption(string error): base(error) { }
        
    }
}
