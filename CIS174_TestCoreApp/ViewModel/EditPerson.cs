using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Models
{
    public class EditPerson
    {
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        

        

    }
}
