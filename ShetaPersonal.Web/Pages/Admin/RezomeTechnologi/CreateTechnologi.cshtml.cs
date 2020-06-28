using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.RezomeTechnologi
{
    [Authorize]
    public class CreateTechnologiModel : PageModel
    {
        private IAdminService _adminService;

        public CreateTechnologiModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.RezomeTecs RezomeTecs { get; set; }
        [BindProperty]
        public int Rezomeid { get; set; }

        public void OnGet(int id)
        {
            Rezomeid = id;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _adminService.CreateTechnologi(RezomeTecs);
            int rid = RezomeTecs.RezomeId;
            return Redirect("/admin/RezomeTechnologi/" + rid);
        }
    }
}