using System.Threading.Tasks;

namespace KeepFit.ViewModels.Services
{
    public interface IMessageService
    {
        Task ShowMessage(string message);
    }
}