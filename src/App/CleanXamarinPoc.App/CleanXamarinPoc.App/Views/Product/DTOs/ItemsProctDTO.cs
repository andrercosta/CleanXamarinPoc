using CleanXamarinPoc.App.Domain.Entities;
using System;
using System.Text;

namespace CleanXamarinPoc.App.Views.Product.DTOs
{

    public class ItemsProctDTO
    {
        public ItemsProctDTO(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public static ItemsProctDTO FromEntity(ItemProductEntity entity)
        {
            return new ItemsProctDTO(entity.Id, entity.Description);
        }
    }
}
