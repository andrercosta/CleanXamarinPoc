using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Data.Http
{
    public class NotFoundErrorExeption : Exception
    {
        public NotFoundErrorExeption(): base("Recurso não encontrado")
        {

        }
    }
}
