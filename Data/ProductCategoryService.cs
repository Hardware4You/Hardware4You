using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public class ProductCategoryService : IProductCategoryService
    {
        readonly private ProductCategoryContext _context;

        public ProductCategoryService(ProductCategoryContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductCategory> GetProductCategories()
        {
            return _context.ProductCategories.ToList();
        }

        public void DeleteProductCategory(long id)
        {
            ProductCategory productCategory = _context.ProductCategories.Find(id);
            if (productCategory != null)
            {
                _context.ProductCategories.Remove(productCategory);
                _context.SaveChanges();
            }
        }

        public void InsertProductCategory(ProductCategory productCategory)
        {
            _context.ProductCategories.Add(productCategory);
            _context.SaveChanges();
        }

        public ProductCategory SingleProductCategory(long id)
        {
            return _context.ProductCategories.Find(id);
        }

        public void UpdateProductCategory(long id, ProductCategory updatedProductCategory)
        {
            var existingProductCategory = _context.ProductCategories.Find(id);

            if (existingProductCategory != null)
            {
                // Eigenschaften von bereits vorhandenen Kategorien
                existingProductCategory.Name = updatedProductCategory.Name;

                _context.SaveChanges();
            }
        }
    }


}
