using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.About
{
    [Authorize]
    public class EditAboutModel : PageModel
    {
        private IAdminService _adminService;

        public EditAboutModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.About About { get; set; }
        public void OnGet(int id)
        {
            About = _adminService.GetInfoAbout(id);
        }

        public IActionResult OnPost(IFormFile ImgProfile)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
        
            _adminService.UpdateAbout(About,ImgProfile);

            return RedirectToPage("index");
        }
    }
}