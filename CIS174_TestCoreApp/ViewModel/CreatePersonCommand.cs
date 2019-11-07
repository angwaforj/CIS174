using System.Collections.Generic;
using System.Linq;
using CIS174_TestCoreApp.Data;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.ViewModel
{
    public class CreatePersonCommand: EditPerson
    {
        public IList<CreateAccomplishmentCommand> Accomplishments { get; set; } = new List<CreateAccomplishmentCommand>();

        public Person ToPerson()
        {
            return new Person
            {
                FirstName = FirstName,
                LastName = LastName,
                Birthdate = Birthdate,
                City = City,
                State = State,
                SetOfAccomplishments = Accomplishments?.Select(x => x.ToAccomplishment()).ToList()
            };
        }
    }
}
