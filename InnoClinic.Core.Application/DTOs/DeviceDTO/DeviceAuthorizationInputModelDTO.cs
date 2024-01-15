using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InnoClinic.Core.Application.DTOs.ConsentDTO;

namespace InnoClinic.Core.Application.DTOs.DeviceDTO
{
    public class DeviceAuthorizationInputModel : ConsentInputModelDTO
    {
        public string UserCode { get; set; }
    }
}
