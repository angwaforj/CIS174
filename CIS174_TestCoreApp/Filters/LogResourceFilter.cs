using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174_TestCoreApp.Filters
{
    public class LogResourceFilter : Attribute, IResourceFilter
    {
       
        public bool IsEnabled { get; set; }
        public Guid RequestId { get; } = new Guid();
        
        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if (context.HttpContext.Request != null)
            {
                context.HttpContext.TraceIdentifier = RequestId.ToString();

            }
            
            if (!IsEnabled)
            {
                context.Result = new BadRequestResult();
            }

        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
           
        }

        
    }
}
