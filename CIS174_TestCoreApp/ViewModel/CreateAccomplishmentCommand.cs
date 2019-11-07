using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CIS174_TestCoreApp.Data;

namespace CIS174_TestCoreApp.ViewModel
{
    public class CreateAccomplishmentCommand
    {
        [Required, StringLength(100)]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfAccomplishment { get; set; }

        public Accomplishment ToAccomplishment()
        {
            return new Accomplishment
            {
                Name = Name,
                DateOfAccomplishment = DateOfAccomplishment
            };
        }
    }
}
