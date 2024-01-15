using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Core.Application.DTOs.AccountDTO
{
    public class ExternalProviderDTO
    {
        public string DisplayName { get; set; }
        public string AuthenticationScheme { get; set; }
    }
}
