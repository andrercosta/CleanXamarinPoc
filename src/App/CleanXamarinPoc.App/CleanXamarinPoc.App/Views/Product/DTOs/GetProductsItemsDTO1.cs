using CleanXamarinPoc.App.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CleanXamarinPoc.App.Views.Product.DTOs
{
    public class GetProductsItemsDTO
    {


        public string Title { get; set; }
        public List<ItemsProctDTO> Items { get; set; }
        public decimal QuantidadesItems { get; set; }
        public GetProductsItemsDTO(string title, List<ItemsProctDTO> items, decimal quantidadesItems)
        {
            this.Title = title;
            this.Items = items;
            this.QuantidadesItems = quantidadesItems;
        }
        public static GetProductsItemsDTO FromEntity(ProductEntity entity)
        {
            var items = entity.Items.Select(ItemsProctDTO.FromEntity).ToList();
            return new GetProductsItemsDTO(entity.Title, items, entity.TotalItems());
        }
    }
}
