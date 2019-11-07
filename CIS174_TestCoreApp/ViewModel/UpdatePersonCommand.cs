using CIS174_TestCoreApp.Data;
using CIS174_TestCoreApp.Models;

namespace CIS174_TestCoreApp.ViewModel
{
    public class UpdatePersonCommand: EditPerson
    {
        public int PersonId { get; set; }

        public void UpdatePerson(Person person)
        {
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Birthdate = Birthdate;
            person.City = City;
            person.State = State;

        }
    }
}
