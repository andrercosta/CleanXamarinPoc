using System;
using System.Collections.Generic;
using System.Text;

namespace CleanXamarinPoc.App.Domain.Entities
{
    public class CardEntity
    {
        public CardEntity(string id, string name, string type, string image)
        {
            Id = id;
            Name = name;
            Type = type;
            Image = image;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
    }
}
