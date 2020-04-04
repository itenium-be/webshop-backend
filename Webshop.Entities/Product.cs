using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public string SKU { get; set; }

        public override string ToString() => $"{Name}, €{Price} ({Id})";
    }
}
