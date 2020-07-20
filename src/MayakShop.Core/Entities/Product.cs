using System;
using System.Collections.Generic;
using System.Text;

namespace MayakShop.Core.Entities
{
    public class Product : BaseEntity
    {
        public string Barcode { get; set; }
        public string Article { get; set; }
        public string Name { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal RetailPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int ManufacturerId { get; set; }
    }
}
