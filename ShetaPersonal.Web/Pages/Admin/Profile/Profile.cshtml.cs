using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Profile
{
    [Authorize]
    public class ProfileModel : PageModel
    {
        private IAdminService _adminService;

        public ProfileModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.About About { get; set; }
        public void OnGet()
        {
            About = _adminService.Getinfo(User.Identity.Name);
        }

        public IActionResult OnPost()
        {
            _adminService.UpdateEmail(About);
            HttpContext.SignOutAsync();
            return Redirect("/admin");
        }
    }
}