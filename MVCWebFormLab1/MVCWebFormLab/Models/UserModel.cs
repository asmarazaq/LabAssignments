using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace MVCWebFormLab.Models
{
    public class UserModel
    {        
        [Required]
        [Display(Name = "FirstName")]
        [StringLength(20, ErrorMessage = "First name length should not exceed")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [Display(Name = "LastName")]
        [StringLength(20, ErrorMessage = "Last name length should not exceed")]
        public string LastName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$", 
            ErrorMessage = "plz enter valid email address")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
            ErrorMessage = "Password must be 8-15 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        public string Password { get; set; }
    }
}