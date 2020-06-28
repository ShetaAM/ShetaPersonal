using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Core.DTO.Admin
{
    public class PasswordViewModel
    {
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [Compare("NewPassword")]
        public string ReNewPassword { get; set; }
    }
}
