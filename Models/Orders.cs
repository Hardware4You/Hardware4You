namespace Hardware4You.Models
{
    public partial class Orders
    {
        public long OrderID { get; set; }
        public string? Status { get; set; }
        public string? cashOnDelivery { get; set; }
        public string? prePayment { get; set; }
        public string? pickCity1 { get; set; }
        public string? pickCity2 { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? phoneNumber { get; set; }
        public string? fullName { get; set; }

        public List<OrderedProduct> SelectedProducts { get; set; }

        public class OrderedProduct
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }
    }
}
