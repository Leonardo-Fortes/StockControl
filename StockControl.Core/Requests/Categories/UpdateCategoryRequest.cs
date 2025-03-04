

using System.ComponentModel.DataAnnotations;

namespace StockControl.Core.Requests.Categories
{
    public class UpdateCategoryRequest : Request
    {
        [Required(ErrorMessage = "O Titulo é obrigatório")]
        [MaxLength(100, ErrorMessage = "Só é permitido 100 caracteres")]
        public string Title { get; set; } = null!;
        [Required(ErrorMessage = "A Descrição é obrigatória")]
        public string Description { get; set; } = string.Empty;
    }
}
