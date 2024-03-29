﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace InnoClinic.Core.Application.DTOs.AccountResponses
{
    public class AuthenticationResponseDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> Roles { get; set; }
        public bool IsVerified { get; set; }
        public bool HasError { get; set; }
        public string? Error { get; set; }
        public string? JWTToken { get; set; }

        [JsonIgnore]
        public string RefreshToken { get; set; }
        public string ImagePath { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
