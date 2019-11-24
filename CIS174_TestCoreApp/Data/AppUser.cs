using Microsoft.AspNetCore.Identity;

namespace CIS174_TestCoreApp.Data
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }   
    }
}
