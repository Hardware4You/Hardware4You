using Hardware4You.Models;
using MudBlazor;

namespace Hardware4You.Data
{
    public class CartService
    {
        public List<Product> SelectedItems { get; set; } = new();

        public void AddProductToCart(long productId, List<Product> products)
        {
            var product = products.First(p => p.Id == productId);

            //if (SelectedItems.Contains(product) is false)
            //{
                SelectedItems.Add(product);     
            //}
        }

        ////beim Kauf eines Produkts im Einkaufskorb verwenden
        //public void BuyProductInCart(Product product)
        //{
        //    product.Quantity -= 1;
        //}

        public void ClearSelectedItems()
        {
            SelectedItems.Clear();
        }
    }
}
