using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Core.Application.ViewModels.Grant
{
    public class GrantViewModel
    {
        public string ClientId { get; set; }
        public string ClientName { get; set; }
        public string ClientUrl { get; set; }
        public string ClientLogoUrl { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Expires { get; set; }
        public IEnumerable<string> IdentityGrantNames { get; set; }
        public IEnumerable<string> ApiGrantNames { get; set; }
        public IEnumerable<GrantViewModel> Grants { get; set; }
    }


}
