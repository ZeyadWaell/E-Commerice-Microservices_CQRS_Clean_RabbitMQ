﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOrderIdentity.Application.DTOs
{
    public class CreateUserRequestDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

}
