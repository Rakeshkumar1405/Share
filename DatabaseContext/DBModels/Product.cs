using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseContext.DBModels
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public string Brand { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public decimal height { get; set; }
        public decimal Width { get; set; }
        public DateTime ExpireBy { get; set; }

    }
}

