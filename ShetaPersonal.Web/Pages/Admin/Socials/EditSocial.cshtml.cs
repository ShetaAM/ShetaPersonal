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
    public class EditSocialModel : PageModel
    {
        private IAdminService _adminService;

        public EditSocialModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Social Social { get; set; }
        public void OnGet(int id)
        {
            Social = _adminService.GetInfoSocial(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.EditSocial(Social);
            return RedirectToPage("index");
        }
    }
}