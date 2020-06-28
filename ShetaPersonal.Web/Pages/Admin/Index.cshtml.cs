using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NUnit.Framework;
using ShetaPersonal.Core.DTO.Admin;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin
{
    
    //[PermissionChecker(1)]
    public class IndexModel : PageModel
    {
        private IAdminService _adminService;

        public IndexModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public LoginViewModel LoginViewModel { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (LoginViewModel.Email==null)
            {
                return Page();
            }

            if (LoginViewModel.Password == null)
            {
                return Page();
            }
            var user = _adminService.LoginUser(LoginViewModel);
            if (user!=null)
            {
                var Claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                    new Claim(ClaimTypes.Name,user.UserName),
                    new Claim(ClaimTypes.Email,user.Email)
                };
                var identity=new ClaimsIdentity(Claims,CookieAuthenticationDefaults.AuthenticationScheme);
                var principal=new ClaimsPrincipal(identity);
                var properties =new AuthenticationProperties()
                {
                    IsPersistent = LoginViewModel.RememberMe
                };
                HttpContext.SignInAsync(principal, properties);
                return RedirectToPage("ControlPanel");

            }
            else
            {
                ModelState.AddModelError("Email","کاربری با مشخصات وارد شده یافت نشد!");
            }

            return Page();

        }
    }
}