using IdentityServer4.Models;
using InnoClinic.Presentation.WebAPI.ViewModels.Consent;

namespace InnoClinic.Core.Application.DTOs.ConsentDTO
{
    public class ProcessConsentResultDTO
    {
        public bool IsRedirect => RedirectUri != null;
        public string RedirectUri { get; set; }
        public Client Client { get; set; }

        public bool ShowView => ViewModel != null;
        public ConsentViewModel ViewModel { get; set; }

        public bool HasValidationError => ValidationError != null;
        public string ValidationError { get; set; }
    }
}
