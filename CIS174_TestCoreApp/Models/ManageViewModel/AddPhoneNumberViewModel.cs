using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models.ManageViewModel
{
    public class AddPhoneNumberViewModel
    {
        [Required]
        [Phone]
        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
    }
}
