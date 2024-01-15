using InnoClinic.Core.Application.DTOs.AccountDTO;

namespace InnoClinic.Core.Application.ViewModels.Account
{
    public class LoginViewModel : LoginInputModelDTO
    {
        public bool AllowRememberLogin { get; set; } = true;
        public bool EnableLocalLogin { get; set; } = true;

        public IEnumerable<ExternalProviderDTO> ExternalProviders { get; set; } = Enumerable.Empty<ExternalProviderDTO>();
        public IEnumerable<ExternalProviderDTO> VisibleExternalProviders => ExternalProviders.Where(x => !String.IsNullOrWhiteSpace(x.DisplayName));

        public bool IsExternalLoginOnly => EnableLocalLogin == false && ExternalProviders?.Count() == 1;
        public string ExternalLoginScheme => IsExternalLoginOnly ? ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;

    }
}
