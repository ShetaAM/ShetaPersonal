using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Tahsilat
{
    [Authorize]
    public class CreateTahsilatModel : PageModel
    {
        private IAdminService _adminService;

        public CreateTahsilatModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public void OnGet()
        {

        }

        [BindProperty]
        public Data.Model.Entities.Tahsilat Tahsilat { get; set; }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.CreateTahsilat(Tahsilat);
            return RedirectToPage("index");
        }
    }
}