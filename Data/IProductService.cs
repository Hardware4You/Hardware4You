using Hardware4You.Models;

namespace Hardware4You.Data
{
    interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Task InsertProductAsync(Product product);  // Ändern Sie den Rückgabetyp in Task
        void UpdateProduct(string name, Product product);
        Product SingleProduct(long id);
        void DeleteProduct(long id);
    }
}