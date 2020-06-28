using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Web.Pages.Admin.Socials
{
    public class CreateSocialModel : PageModel
    {
        private IAdminService _adminService;

        public CreateSocialModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Social Social { get; set; }
        public void OnGet()
        {

        }

        public IActionResult Onpost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.CreateSocial(Social);
            return RedirectToPage("index");
        }
    }
}