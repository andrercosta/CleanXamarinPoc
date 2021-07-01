using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanXamarinPoc.App.Domain.Entities
{
    public class ProductEntity
    {
        public ProductEntity(int id, string title, decimal price, List<ItemProductEntity> items)
        {
            Id = id;
            Title = title;
            Price = price;
            Items = items;
        }

        public int Id { get; set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public List<ItemProductEntity> Items { get; set; }

        public decimal TotalItems()
        {
            return Items.Sum(x => x.Quantity);
        }
    }
}
