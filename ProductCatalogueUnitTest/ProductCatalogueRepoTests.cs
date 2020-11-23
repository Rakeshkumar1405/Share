using Moq;
using NUnit.Framework;
using DatabaseContext;
using Repository;
using DatabaseContext.DBModels;
using System.Collections.Generic;

namespace ProductCatalogueUnitTest
{
    public class ProductCategoryUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }
        public void GetProductCategories_Must_Return_AllProductCategories()
        {
            // Prepare
            var dbContext = new Mock<IDBContext>();

            // set up 
            dbContext.Setup(x => x.GetProductCategories()).Returns(GetFakeProductCategoriesData());

            var productCategoryRepo = new ProductCategoryRepository(dbContext.Object);
            var result = productCategoryRepo.GetProductCategories();


            //Assert
            Assert.AreEqual("TV", result[0].CategoryName);
        }

        private List<ProductCategory> GetFakeProductCategoriesData()
        {
            var productCategories = new List<ProductCategory>();
            productCategories.Add(new ProductCategory() { CategoryID = 1, CategoryName = "TV" });
            productCategories.Add(new ProductCategory() { CategoryID = 2, CategoryName = "Speaker" });
            return productCategories;
        }
    }
}