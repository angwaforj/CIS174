using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Data
{
    public class Accomplishment
    {
        //create accomplishment entity
        public int Id { get; set; }

        public int PersonId { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public DateTime DateOfAccomplishment { get; set; }
    }
}
