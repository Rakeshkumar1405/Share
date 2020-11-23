using System;
using DatabaseContext.DBModels;
using System.Collections.Generic;

namespace DatabaseContext
{
    public interface IDBContext
    {
        //Product
        public List<Product> GetProducts();
        public Product GetProductById(int Id);
        public Product CreateProducts(Product products);
        public bool DeleteProducts(int Id);

        //ProductCategory
        public List<ProductCategory> GetProductCategories();
       
        public ProductCategory CreateProductCategory(ProductCategory productCategory);
        public bool DeleteProductCategory(int Id);


    }
}
