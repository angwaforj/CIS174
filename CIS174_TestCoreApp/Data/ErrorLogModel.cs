using System;
using System.ComponentModel.DataAnnotations;

namespace CIS174_TestCoreApp.Data
{
    public class ErrorLogModel
    {
        public int Id { get; set; }

        [Display(Name = "Status Code")]
        public int StatusCode { get; set; }

        public string RequestId { get; set; }

        [Display(Name = "Time of Error")]
        public DateTime ErrorTime { get; set; }

        [Display(Name = "Exception Message")]
        public string ExceptionMessage { get; set; }

        [Display(Name = "Stack trace")]
        public string StackTrace { get; set; }
    }
}
