﻿using System.ComponentModel.DataAnnotations;

namespace SawsAppTemplate.Application.Requests.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}