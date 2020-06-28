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
    public class EditTahsilatModel : PageModel
    {
        private IAdminService _adminService;

        public EditTahsilatModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Tahsilat Tahsilat { get; set; }
        public void OnGet(int id)
        {
            Tahsilat = _adminService.GetInfoTahsilatForedit(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.EditTahsilat(Tahsilat);
            return RedirectToPage("index");
        }
        
    }
}