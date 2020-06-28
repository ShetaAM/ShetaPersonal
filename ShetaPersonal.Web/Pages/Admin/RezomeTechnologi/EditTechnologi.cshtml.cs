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
    public class EditTechnologiModel : PageModel
    {
        private IAdminService _adminService;

        public EditTechnologiModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [BindProperty]
        public Data.Model.Entities.RezomeTecs RezomeTecs { get; set; }

        int Rezomeid;
        public void OnGet(int id)
        {
            RezomeTecs = _adminService.GetInfoTechnologi(id);
            Rezomeid = RezomeTecs.RezomeId;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.EditTechnologi(RezomeTecs);
            int rid = RezomeTecs.RezomeId;
            return Redirect("/admin/RezomeTechnologi/" + rid);
        }
    }
}