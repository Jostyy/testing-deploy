
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Flunt.Notifications;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(20, ErrorMessage = "Entre 3 a 20 caracteres")]
        [MinLength(3, ErrorMessage = "Entre 3 a 20 caracteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Campo obrigatorio")]
        [MaxLength(20, ErrorMessage = "Entre 3 a 20 caracteres")]
        [MinLength(3, ErrorMessage = "Entre 3 a 20 caracteres")]
        public string Password { get; set; }

        public string Role { get; set; }

    }
}