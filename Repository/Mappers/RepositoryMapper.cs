using System;
using System.Collections.Generic;
using System.Text;
using Repository.Models;
using DatabaseContext.DBModels;

namespace Repository.Mappers
{
    public class RepositoryMapper
    {
        public static List<ProductCatalogueModel> MapDBModelToRepository(List<Product> dbProducts)
        {
            var productCatalogues = new List<ProductCatalogueModel>();
            foreach(var dbproduct in dbProducts)
            {

                productCatalogues.Add(new ProductCatalogueModel()
                {
                    ProductId = dbproduct.ProductId,
                    ProductName = dbproduct.ProductName,
                    ProductCategory = new ProductCategoryModel() 
                                        { CategoryId = dbproduct.ProductCategory.CategoryID,
                                        CategoryName = dbproduct.ProductCategory.CategoryName},
                    Description = dbproduct.Description,
                    Brand = dbproduct.Brand
                });
            }

            return productCatalogues;
        }
        public static Product MapRepositoryToDBProduct(ProductCatalogueModel productCatalogue)
        {
            var dbproduct = new Product();
            dbproduct.ProductId = productCatalogue.ProductId;
            dbproduct.ProductName = productCatalogue.ProductName;
            dbproduct.ProductCategory = new ProductCategory()
            {
                CategoryID = dbproduct.ProductCategory.CategoryID,
                CategoryName = dbproduct.ProductCategory.CategoryName
            };
            dbproduct.Description = productCatalogue.Description;
            dbproduct.Brand = productCatalogue.Brand;
            return dbproduct;
        }


        public static List<ProductCategoryModel> MapDBCategoryModelToRepository(List<ProductCategory> dbCategories)
        {
            var productCategories = new List<ProductCategoryModel>();
            foreach (var dbCategory in dbCategories)
            {

                productCategories.Add(new ProductCategoryModel()
                {
                    CategoryId = dbCategory.CategoryID,
                    CategoryName = dbCategory.CategoryName,
                   
                });
            }

            return productCategories;
        }
        public static ProductCategory MapRepoCategoryToDBCategory(ProductCategoryModel productCategory)
        {
            var dbcategory = new ProductCategory();
            dbcategory.CategoryID = productCategory.CategoryId;
            dbcategory.CategoryName = productCategory.CategoryName;
            return dbcategory;
        }
    }
}
