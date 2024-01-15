using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Core.Application.DTOs.ConsentDTO
{
    public class ConsentInputModelDTO
    {
        public string Button { get; set; }
        public IEnumerable<string> ScopesConsented { get; set; }
        public bool RememberConsent { get; set; }
        public string ReturnUrl { get; set; }
        public string Description { get; set; }
    }
}
