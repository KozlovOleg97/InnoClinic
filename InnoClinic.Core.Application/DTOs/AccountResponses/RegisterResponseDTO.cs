﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoClinic.Core.Application.DTOs.AccountResponses
{
    public class RegisterResponseDTO
    {
        public bool HasError { get; set; }
        public string? Error { get; set; }
    }
}
