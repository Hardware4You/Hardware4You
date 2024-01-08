using Hardware4You.Models;
using Microsoft.EntityFrameworkCore;

namespace Hardware4You.Data
{
    public class ProductService : IProductService
    {
        readonly private ProductContext _context;

        public ProductService(ProductContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _context.Products.ToList();
            }
            catch
            {
                throw;
            }
        }

        public void DeleteProduct(long id)
        {
            try
            {
                Product product = _context.Products.Find(id);
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }

        public async Task InsertProductAsync(Product product)
        {
            try
            {

                if (product == null)
                {
                    throw new ArgumentNullException(nameof(product));
                }

                // Bild muss vorhanden sein, bevor gespeichert werden darf
                if (product.Media == null && product.MediaType == null)
                {
                    throw new InvalidOperationException("Bild muss eingefügt werden, bevor gespeichert werden darf!");
                }

                _context.Products.Add(product);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw;
            }
        }

        public Product SingleProduct(long id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(string name, Product product)
        {
            try
            {
                var local = _context.Set<Product>().Local.FirstOrDefault(entry => entry.Id.Equals(product.Id));

                if (local != null)
                {
                    _context.Entry(local).State = EntityState.Detached;
                }
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}
