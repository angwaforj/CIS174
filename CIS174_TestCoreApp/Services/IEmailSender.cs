using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
