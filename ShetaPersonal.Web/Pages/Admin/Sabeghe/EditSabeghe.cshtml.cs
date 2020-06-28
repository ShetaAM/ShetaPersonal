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
    public class EditSabegheModel : PageModel
    {
        private IAdminService _adminService;

        public EditSabegheModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Sabeghe Sabeghe { get; set; }
        public void OnGet(int id)
        {
            Sabeghe = _adminService.GetInfoSabeghe(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
                
            }
            _adminService.EditSabeghe(Sabeghe);
            return RedirectToPage("index");
        }
    }
}