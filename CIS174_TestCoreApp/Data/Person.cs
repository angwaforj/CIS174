using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Data
{
    public class Person
    {
        //create a person entity
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTime Birthdate { get; set; }
        [StringLength(70)]
        public string City { get; set; }
        [StringLength(70)]
        public string State { get; set; }

        public bool IsDeleted { get; set; }

        public ICollection<Accomplishment> SetOfAccomplishments { get; set; }




    }

    
}
