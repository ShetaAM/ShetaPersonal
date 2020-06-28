using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Danesh
{
    [Authorize]
    public class EditDaneshModel : PageModel
    {
        private IAdminService _adminService;

        public EditDaneshModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Danesh Danesh { get; set; }
        public void OnGet(int id)
        {
            Danesh = _adminService.GetInfoDanesh(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _adminService.EditDanesh(Danesh);
            return RedirectToPage("index");
        }
    }
}