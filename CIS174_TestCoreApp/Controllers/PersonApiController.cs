using CIS174_TestCoreApp.Filters;
using CIS174_TestCoreApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Assignment 11.1 Custom filters
/// </summary>
namespace CIS174_TestCoreApp.Controllers
{
    [Route("api/person")]
    [ApiController]
    [ValidateModel, HandleExceptionFilter, LogResourceFilter(IsEnabled = true) ]
    public class PersonApiController : ControllerBase
    {
        private readonly PersonServices _service;

        public PersonApiController(PersonServices service)
        {
            _service = service;
        }

        [HttpGet("{id}"),EnsurePersonExist]
        public IActionResult Get(int id)
        {
            var detail = _service.GetPersonDetails(id);
            return Ok(detail);
        }

        [HttpPost("{id}"), EnsurePersonExist]
        public IActionResult Edit(int id, [FromBody] UpdatePersonCommand command)
        {
            _service.UpdatePerson(command);
            return Ok();
        }
    }
}