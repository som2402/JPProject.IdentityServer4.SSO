﻿using System.ComponentModel.DataAnnotations;
using JPProject.Domain.Core.StringUtils;

namespace Jp.UI.SSO.Models
{
    public class LoginInputModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }

        public bool IsUsernameEmail()
        {
            // Return true if strIn is in valid e-mail format.
            return Username.IsEmail();
        }
    }
}