using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hardware4You.Models
{
    public partial class Product
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public byte[] Media { get; set; } // aktualisierte Eigenschaft
        public string MediaType { get; set; } // aktualisierte Eigenschaft
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }
    }
}