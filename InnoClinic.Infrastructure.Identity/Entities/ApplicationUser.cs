using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Infrastructure.Identity.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // Demo
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string IDCard { get; set; }
        public string ImagePath { get; set; }

    }
}
