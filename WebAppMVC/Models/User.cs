using System.ComponentModel.DataAnnotations;

namespace WebAppMVC.Models
{
    public class User
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        public string  UserName { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
         public string Password { get; set; }

      
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }


        

        [Required(ErrorMessage = "Contact Number is Required.")]
        [StringLength(10, ErrorMessage ="Max 10 digits only allowed in Contact")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Contact Number.")]
        public string Contact { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public string Gender { get; set; }

        public bool Terms { get; set; }
    }

    public enum Country
    {
        India,
        UK,
        USA
    }


}
