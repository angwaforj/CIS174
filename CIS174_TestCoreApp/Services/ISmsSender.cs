using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
