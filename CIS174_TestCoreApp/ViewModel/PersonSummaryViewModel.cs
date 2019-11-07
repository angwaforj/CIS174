using System;
using CIS174_TestCoreApp.Data;

namespace CIS174_TestCoreApp.ViewModel
{
    public class PersonSummaryViewModel
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string NumberOfAccomplishments { get; set; }


        public static PersonSummaryViewModel FromPerson(Person persons, Accomplishment accomplishment)
        {
            return new PersonSummaryViewModel
            {
                PersonId = persons.Id,
                FirstName = persons.FirstName,
                LastName = persons.LastName,
                NumberOfAccomplishments = accomplishment.Name
            };
        }
    }
}
  
