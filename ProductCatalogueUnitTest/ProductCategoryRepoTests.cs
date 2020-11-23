using Moq;
using NUnit.Framework;
using DatabaseContext;
using Repository;
using DatabaseContext.DBModels;
using System.Collections.Generic;

namespace ProductCatalogueUnitTest
{
    public class ProductCatalogueUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }
        public void GetProducts_Must_Return_AllProducts()
        {
            // Prepare
            var dbContext = new Mock<IDBContext>();

            // set up 
            dbContext.Setup(x => x.GetProducts()).Returns(GetFakeProductData());

            var productcatalogueRepo = new ProductCatalogueRepository(dbContext.Object);
            var result = productcatalogueRepo.GetProducts();


            //Assert
            Assert.AreEqual("Smart TV", result[0].ProductName);
        }

        public void GetProductById_Must_Return_SingleProductForGivenId()
        {
            // Prepare
            var dbContext = new Mock<IDBContext>();

            // set up 
            dbContext.Setup(x => x.GetProductById(1)).Returns(GetFakeProductData()[0]);

            var productcatalogueRepo = new ProductCatalogueRepository(dbContext.Object);
            var result = productcatalogueRepo.GetProductById(1);
            

            //Assert
            Assert.AreEqual("Smart TV", result.ProductName);
        }

        public void GetProductById_Must_Return_NotFound()
        {
            // Prepare
            var dbContext = new Mock<IDBContext>();

            // set up 
            dbContext.Setup(x => x.GetProductById(1)).Returns(GetFakeProductData()[0]);

            var productcatalogueRepo = new ProductCatalogueRepository(dbContext.Object);
            var result = productcatalogueRepo.GetProductById(1);


            //Assert
            Assert.AreEqual("Smart TV", result.ProductName);
        }

        private List<Product> GetFakeProductData()
        {
            var products = new List<Product>();
            var category1 = new ProductCategory() { CategoryID = 1, CategoryName = "TV" };
            var category2 = new ProductCategory() { CategoryID = 2, CategoryName = "Speaker" };
            products.Add(new Product() { ProductId = 1, ProductName = "Smart TV", ProductCategory = category1, Description = "TV", Brand = "LG", UnitPrice = 50000.00M });
            products.Add(new Product() { ProductId = 2, ProductName = "Smart phone", ProductCategory = category2, Description = "Phone", Brand = "Redemi", UnitPrice = 20000.00M });
            return products;
        }
    }
}