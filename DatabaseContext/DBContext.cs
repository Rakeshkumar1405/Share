using System;
using DatabaseContext.DBModels;
using System.Collections.Generic;

namespace DatabaseContext
{
    public class DBContext : IDBContext
    {
        public List<Product> GetProducts()
        {
            // Populate dList with dummy Product. This has to be fetched from database once database installed.

            var products = new List<Product>();
            var category1 = new ProductCategory() { CategoryID = 1, CategoryName = "TV" };
            var category2 = new ProductCategory() { CategoryID = 2, CategoryName = "Speaker" };
            products.Add(new Product() { ProductId = 1, ProductName = "Smart TV",ProductCategory = category1, Description = "TV", Brand = "LG", UnitPrice = 50000.00M });
            products.Add(new Product() { ProductId = 2, ProductName = "Smart phone", ProductCategory = category2, Description = "Phone", Brand = "Redemi", UnitPrice = 20000.00M });

            return products;
        }
        public Product GetProductById(int Id)
        {
            //Todo: Need t fetch the Product for given ID
            Product product = null;
            try
            {
                var category1 = new ProductCategory() { CategoryID = 1, CategoryName = "TV" };
                product = new Product() { ProductId = 1, ProductName = "Smart TV", ProductCategory = category1, Description = "TV", Brand = "LG", UnitPrice = 50000.00M };
            }
            catch(Exception ex)
            {
                // log exception here
            }
            return product;
        }

        public Product CreateProducts(Product products)
        {
            // Database code to create product into database and return the created record
            var category = new ProductCategory() { CategoryID = 1, CategoryName = "TV" };
            var product = new Product() { ProductId = 1, ProductName = "Smart TV", ProductCategory = category, Description = "TV", Brand = "LG", UnitPrice = 50000.00M };
           return product;
        }
        public bool DeleteProducts(int Id)
        {
            // Database code to delete product from database
            return true;
        }
        public List<ProductCategory> GetProductCategories()
        {
            // Populate List with dummy Product category. This has to be fetched from database once database installed.

            var productCategories = new List<ProductCategory>();
            productCategories.Add(new ProductCategory() { CategoryID = 1, CategoryName = "TV" });
            productCategories.Add(new ProductCategory() { CategoryID = 2, CategoryName = "Speaker" });
           
            return productCategories;
        }
        
        public ProductCategory CreateProductCategory(ProductCategory productCategory)
        {
            // Database code to create product category into database and return the created record
            var category = new ProductCategory() { CategoryID = 1, CategoryName = "TV" };
            return category;
        }
        public bool DeleteProductCategory(int Id)
        {
            // Database code to delete product category from database
            return true;
        }




    }
}
