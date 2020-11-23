using DatabaseContext;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IProductCategoryRepository
    {
        public List<ProductCategoryModel> GetProductCategories();
        public ProductCategoryModel CreateProductCategory(ProductCategoryModel productCategory);
        public bool DeleteProductCategory(int Id);
    }
}
