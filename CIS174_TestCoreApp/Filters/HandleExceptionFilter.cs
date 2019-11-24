using System;
using CIS174_TestCoreApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CIS174_TestCoreApp.Filters
{
    public class HandleExceptionFilter: ExceptionFilterAttribute
    {
        private readonly ApplicationDbContext _context; //instance of ApplicationDbContext class

        public HandleExceptionFilter()
        {
        }


        //Create a constructor of ApplicationDbContext class
        public HandleExceptionFilter(ApplicationDbContext context)
        {
            _context = context;
        }
        public override void OnException(ExceptionContext context)
        {
            var error = new
            {
                Success = false,
                Errors = new [] { context.Exception.Message }
            };

            context.Result = new ObjectResult(error)
            {
                StatusCode = 500
            };
            context.Result = new ObjectResult(error)
            {
                StatusCode = 400
            };


             ErrorLogModel errorLog = new ErrorLogModel
            {
                ErrorTime = DateTime.UtcNow,
                RequestId = context.HttpContext.TraceIdentifier,
                StackTrace = context.Exception.StackTrace,
                StatusCode = context.Exception.HResult,
                ExceptionMessage = context.Exception.Message
            };
             _context.ErrorLog.Add(errorLog);
             _context.SaveChanges();

             context.ExceptionHandled = true;
        }
    }
}
