using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CIS174_TestCoreApp.Models.ManageViewModel
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}
