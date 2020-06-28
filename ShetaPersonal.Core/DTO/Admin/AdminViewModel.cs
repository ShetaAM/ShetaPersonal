using System;
using System.Collections.Generic;
using System.Text;

namespace ShetaPersonal.Core.DTO.Admin
{
    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
