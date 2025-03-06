using StockControl.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace StockControl.Core.Requests.Products
{
    public class UpdateProductRequest : Request
    {
        [Required(ErrorMessage = "Titulo inválido")]
        public string Title { get; set; } = null!;
        [Required]
        public MovimentType MovimentType { get; set; } = MovimentType.Entry;
        [Required(ErrorMessage = "Quantidade inválida")]
        public int Quantity { get; set; } = 1;
        [Required(ErrorMessage = "Categoria inválida")]
        public int CategoryId { get; set; }
    }
}
