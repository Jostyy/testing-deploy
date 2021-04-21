
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(60, ErrorMessage = "Entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Entre 3 a 60 caracteres")]
        public string Title { get; set; }
        [MaxLength(1000, ErrorMessage = "Máximo de 1000 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Preço deve ser maior que zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Id categoria invalido")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}