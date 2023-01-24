using System.ComponentModel.DataAnnotations;

namespace JWT_Practice.Models
{
    public class SingInModel
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
