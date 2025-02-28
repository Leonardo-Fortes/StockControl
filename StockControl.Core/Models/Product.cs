using StockControl.Core.Enums;

namespace StockControl.Core.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; } = null!;

        public MovimentType MovimentType { get; set; } = MovimentType.Entry;

        public int Quantity { get; set; } = 1;

        public int CategoryId { get; set; }

        public Category Category { get; set; } = null!;


    }
}
