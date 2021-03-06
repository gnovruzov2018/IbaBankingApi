﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbaBankingApi.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { set; get; }
        
        [Required]
        [StringLength(16, MinimumLength =8, ErrorMessage = "You must specify password between 8 and 16 characters")]
        public string Password { set; get; }
    }
}
