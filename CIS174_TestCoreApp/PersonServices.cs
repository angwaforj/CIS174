using System;
using System.Collections.Generic;
using CIS174_TestCoreApp.Data;
using CIS174_TestCoreApp.ViewModel;

using System.Linq;
using Microsoft.Extensions.Logging;

namespace CIS174_TestCoreApp
{
    public class PersonServices
    {
        readonly ApplicationDbContext _dbContext;
        

        public PersonServices(ApplicationDbContext context)
        {
            _dbContext = context;
           
        }

        //Create a summary of all person
        public ICollection<PersonSummaryViewModel> GetPerson()
        {
            return _dbContext.Persons
                .Where(r => !r.IsDeleted)
                .Select(x => new PersonSummaryViewModel
                {
                    PersonId = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    NumberOfAccomplishments = x.SetOfAccomplishments.Count().ToString()
                })
                .ToList();
        }

        //Show detail of one person
        public PersonDetailsViewModel GetPersonDetails(int id)
        {
            return _dbContext.Persons
                .Where(x => x.Id == id)
                .Where(x => !x.IsDeleted)
                .Select(x => new PersonDetailsViewModel
                {
                    PersonId = x.Id,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Birthdate = x.Birthdate,
                    City = x.City,
                    State = x.State,
                    Record = x.SetOfAccomplishments
                        .Select(item => new PersonDetailsViewModel.Accomplish
                        {
                            Name = item.Name,
                            DateOfAccomplishment = item.DateOfAccomplishment
                        })
                }).SingleOrDefault();
        }

        //Find person to update by id
        public UpdatePersonCommand GetPersonForUpdate(int id)
        {
            return _dbContext.Persons
                .Where(x => x.Id == id)
                .Where(x => !x.IsDeleted)
                .Select(x => new UpdatePersonCommand
                {

                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Birthdate = x.Birthdate,
                    City = x.City,
                    State = x.State,
                }).SingleOrDefault();
        }
        //Create Person 
        public int CreatePerson(CreatePersonCommand cmd)
        {
            var person = cmd.ToPerson();
            _dbContext.Add(person);
            _dbContext.SaveChanges();
            return person.Id;
        }


        /// <summary>
        /// Update person using id
        /// </summary>
        /// <param name="cmd"></param>
        public void UpdatePerson(UpdatePersonCommand cmd)
        {
            var person = _dbContext.Persons.Find(cmd.PersonId);
            if (person == null) { throw new Exception("Unable to find the person"); }
            if (person.IsDeleted) { throw new Exception("Unable to update a deleted person"); }

            cmd.UpdatePerson(person);
            _dbContext.SaveChanges();
        }

        public void DeletePerson(int personId)
        {
            var person = _dbContext.Persons.Find(personId);
            if (person.IsDeleted) { throw new Exception("Unable to delete a deleted person"); }

            person.IsDeleted = true;
            _dbContext.SaveChanges();
        }
    }
}
