using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter UserId")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
