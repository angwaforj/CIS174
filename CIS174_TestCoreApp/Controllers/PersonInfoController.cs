using System;
using CIS174_TestCoreApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.Controllers
{
    public class PersonInfoController : Controller
    {
        private readonly PersonServices _person; // create an instance of Person class

        //Create a PersonInfo constructor
        public PersonInfoController(PersonServices person)
        {
            _person = person;
        }
        public IActionResult Index()
        {
            var models = _person.GetPerson();

            return View(models);
        }

        public IActionResult View(int id)
        {
            var model = _person.GetPersonDetails(id);

            if (model == null)
            {
                return NotFound(); //Return not found (404 friendly page) if model is null
            }

            return View(model);
        }

        public IActionResult Create()
        {
            return View(new CreatePersonCommand());
        }

        [HttpPost]
        public IActionResult Create(CreatePersonCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var id = _person.CreatePerson(command);
                    return RedirectToAction(nameof(View), new {id = id});
                }
            }
            catch (Exception)
            {
                
                // Add a model-level error by using an empty string key
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured saving person"
                );
            }

            //If we got to here, something went wrong
            return View(command);
        }

        public IActionResult Edit(int id)
        {
            var model = _person.GetPersonForUpdate(id);

            if (model == null)
            {
                return NotFound(); //Return not found (404 friendly page) if model is null
            }

            return View(model);

        }
        [HttpPost]
        public IActionResult Edit(UpdatePersonCommand command)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _person.UpdatePerson(command);
                    return RedirectToAction(nameof(View), new { id = command.PersonId });
                }
            }
            catch (Exception)
            {

                // Add a model-level error by using an empty string key
                ModelState.AddModelError(
                    string.Empty,
                    "An error occured updating person"
                );
            }

            //If we got to here, something went wrong
            return View(command);
        }
        [HttpPost]
        public IActionResult DeletePerson(int id)
        {
            _person.DeletePerson(id);
            return RedirectToAction(nameof(Index));
        }
    }
}