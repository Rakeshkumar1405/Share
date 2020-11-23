using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Models
{
    public class ProductCatalogueModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Brand { get; set; }
        public ProductCategoryModel ProductCategory { get; set; }
    }
    public class ProductCategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
