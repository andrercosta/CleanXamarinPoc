using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Main.Factories.Http
{
    public static class ApiUrlFactory
    {
        public static string MakeApiUrl(string path)
        {
            return $"http://www.api.com/{path}";
        }
    }
}
