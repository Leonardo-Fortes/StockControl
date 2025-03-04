
using StockControl.Core.Extensions;

namespace StockControl.Core.Models
{
    public class StockMovementHistory
    {
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public string Title { get; set; } = string.Empty;

        public string UserId { get; set; } = string.Empty;
    }
}
