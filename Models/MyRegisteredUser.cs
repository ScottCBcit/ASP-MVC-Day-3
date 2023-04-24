
using System.ComponentModel.DataAnnotations;

namespace WebAppIdentity1.Models
{
    public class MyRegisteredUser
    {
        [Key]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
    }
}
