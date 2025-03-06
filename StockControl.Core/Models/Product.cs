using StockControl.Core.Enums;

namespace StockControl.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public MovimentType MovimentType { get; set; } = MovimentType.Entry;

        public DateTime DateStockMovement { get; set; } = DateTime.UtcNow;

        public int Quantity { get; set; } = 1;

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public string UserId { get; set; } = string.Empty;

    }
}
