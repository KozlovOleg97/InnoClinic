using InnoClinic.Core.Application.DTOs.ConsentDTO;

namespace InnoClinic.Presentation.WebAPI.ViewModels.Consent
{
    public class ConsentViewModel : ConsentInputModelDTO
    {
        public string ClientName { get; set; }
        public string ClientUrl { get; set; }
        public string ClientLogoUrl { get; set; }
        public bool AllowRememberConsent { get; set; }

        public IEnumerable<ScopeViewModel> IdentityScopes { get; set; }
        public IEnumerable<ScopeViewModel> ApiScopes { get; set; }
    }
}
