using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Domain.Entities
{
    public class ItemProductEntity
    {
       
       
        public ItemProductEntity(int id, string description, int quantity)
        {
            Id = id;
            Description = description;
            Quantity = quantity;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}
