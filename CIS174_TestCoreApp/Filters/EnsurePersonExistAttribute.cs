using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174_TestCoreApp.Filters
{
    public class EnsurePersonExistAttribute: TypeFilterAttribute
    {
        public EnsurePersonExistAttribute() : base(typeof(Filters.EnsurePersonExistAttribute))
        {
        }
        public class EnsurePersonExistFilter : IActionFilter
        {
            private readonly PersonServices _service;
            public EnsurePersonExistFilter(PersonServices service)
            {
                _service = service;
            }

            public void OnActionExecuting(ActionExecutingContext context)
            {
                var personId = (int) context.ActionArguments["id"];
                var personName = (string) context.ActionArguments["name"];
                if (!_service.DoesPersonExist(personId))
                {
                    context.Result = new NotFoundResult();
                }

                if (!_service.DoesNameMatch(personName))
                {
                    context.Result = new StatusCodeResult(404);//404 status code means request not found
                }
            }

            public void OnActionExecuted(ActionExecutedContext context) { }
        }
    }

}
