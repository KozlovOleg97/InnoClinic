using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Core.Application.DTOs.AccountRequests
{
    public class RegisterRequestDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? UserName { get; set; }
        public string Password { get; set; }
        //public string ConfirmPassword { get; set; }
        public int Phone { get; set; }
        public string? ImagePath { get; set; }
        public bool EmailConfirmed { get; set; } = false;
    }
}
