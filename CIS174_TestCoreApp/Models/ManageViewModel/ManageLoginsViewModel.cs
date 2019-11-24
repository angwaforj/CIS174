using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using CIS174_TestCoreApp.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.WindowsAzure.Storage.Blob.Protocol;


namespace CIS174_TestCoreApp.Models.ManageViewModel
{
    public class ManageLoginsViewModel
    {
        public IList<UserLoginInfo> CurrentLogins { get; set; }

        public IList<AuthenticationScheme> OtherLogins { get; set; }

    }
}
