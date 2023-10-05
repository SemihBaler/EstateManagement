﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Dtos.UserDtos
{
    public class AddUserDto
    {
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Mail { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }

    }
}
