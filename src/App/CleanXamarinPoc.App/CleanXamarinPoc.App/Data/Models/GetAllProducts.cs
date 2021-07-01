using CleanXamarinPoc.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanXamarinPoc.App.Data.Models
{
    public class GetAllProductsModel
    {
        public int Id { get; set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public List<ItemsGetAllProducts> Items { get; set; }

        public static IList<ProductEntity> ToListEntity(IEnumerable<GetAllProductsModel> products)
        {
            return products.Select(ToEntity).ToList();
        }
        public static ProductEntity ToEntity(GetAllProductsModel data)
        {
            var items = data.Items.Select(ItemsGetAllProducts.ToEntity).ToList();

            return new ProductEntity(data.Id, data.Title, data.Price, items);
        }
    }

    public class ItemsGetAllProducts
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
       
        public static  ItemProductEntity ToEntity(ItemsGetAllProducts data)
        {
            return new ItemProductEntity(data.Id, data.Description,data.Quantity);
        }
    }
}
