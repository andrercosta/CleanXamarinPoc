using CleanXamarinPoc.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanXamarinPoc.App.Domain.UseCases
{
    public interface IGetAllProducts
    {
        Task<IList<ProductEntity>> GetAllProducts();
    }
}
