using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.DTO.Admin;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Profile
{
    [Authorize]
    public class ChangePasswordModel : PageModel
    {
        private IAdminService _adminService;

        public ChangePasswordModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public PasswordViewModel PasswordViewModel { get; set; }    
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (_adminService.isexistUser(PasswordViewModel.OldPassword))
            {
                _adminService.UpdataPassword(User.Identity.Name,PasswordViewModel.NewPassword);
            }
            else
            {
                ModelState.AddModelError("oldpasswor","رمز عبور فعلی اشتباست");
            }

            HttpContext.SignOutAsync();
            return Redirect("/admin");
        }
    }
}