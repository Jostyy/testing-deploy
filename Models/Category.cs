
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Campo Obrigatorio")]
        [MaxLength(60, ErrorMessage = "Campo entre 3 a 60 caracteres")]
        [MinLength(3, ErrorMessage = "Campo entre 3 a 60 caracteres")]
        public string Title { get; set; }

    }

}