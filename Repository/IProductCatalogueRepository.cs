using DatabaseContext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IProductCatalogueRepository
    {
        public List<ProductCatalogueModel> GetProducts();
        public ProductCatalogueModel GetProductById(int Id);
        public List<ProductCatalogueModel> GetProductCataloguesByCategory(int Id);
        public ProductCatalogueModel CreateProduct(ProductCatalogueModel productCatalogue);
        public bool DeleteProductById(int Id);
    }
}
