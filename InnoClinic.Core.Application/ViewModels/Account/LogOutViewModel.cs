using InnoClinic.Core.Application.DTOs.AccountDTO;

namespace InnoClinic.Core.Application.ViewModels.Account
{
    public class LogOutViewModel : LoginInputModelDTO
    {
        public bool ShowLogoutPrompt { get; set; } = true;
    }
}
