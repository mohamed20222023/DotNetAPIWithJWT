﻿using System.ComponentModel.DataAnnotations;

namespace TestAPIJWT.Models
{
    public class RoleModel
    {
        [Required]
        public string UserId { get; set; }
        
        [Required]
        public string Role { get; set; }


    }
}
