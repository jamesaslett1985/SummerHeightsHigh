
using System.ComponentModel.DataAnnotations;

namespace Website.Models
{
    public class ModelBindingExample
    {
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string MailAddress { get; set; }
    }
}
