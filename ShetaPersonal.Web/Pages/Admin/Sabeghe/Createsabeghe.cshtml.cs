using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Sabeghe
{
    [Authorize]
    public class CreateSabegheModel : PageModel
    {
        private IAdminService _adminService;

        public CreateSabegheModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public void OnGet()
        {

        }

        [BindProperty]
        public Data.Model.Entities.Sabeghe Sabeghe { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.CreateSabeghe(Sabeghe);
            return RedirectToPage("index");
        }
    }
}