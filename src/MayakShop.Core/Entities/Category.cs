using System;
using System.Collections.Generic;
using System.Text;

namespace MayakShop.Core.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public int? ParentCategoryId { get; set; }

        public Category ParentCategory { get; set; }

        public IEnumerable<Category> ChildCategories { get; set; }

        public IList<Product> Products { get; set; }
    }
}
