using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.ViewModel
{
    public class PersonDetailsViewModel 
    {
        public int PersonId { get; set; }

        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Display(Name="Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public IEnumerable<Accomplish> Record { get; set; }

        public class Accomplish
        {
            public string Name { get; set; }
            public DateTime DateOfAccomplishment { get; set; }
        }

        
    }
}
