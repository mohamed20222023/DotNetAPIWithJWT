﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TestAPIJWT.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required , StringLength(50)]
        public string FirstName { get; set; }

        [Required, StringLength(50)]
        public string LastName { get; set; }

    }
}
