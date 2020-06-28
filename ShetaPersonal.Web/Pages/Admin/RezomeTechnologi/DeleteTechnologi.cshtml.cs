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
    public class DeleteTechnologiModel : PageModel
    {
        private IAdminService _adminService;

        public DeleteTechnologiModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public ShetaPersonal.Data.Model.Entities.RezomeTecs RezomeDetail { get; set; }
        public void OnGet(int id)
        {
            RezomeDetail = _adminService
                .GetInfoTechnologi(id);
            ViewData["detailid"] = id;
        }

        public IActionResult OnPost(int detailid)

        {
            _adminService.DeleteTechnologi(detailid);
            return Redirect("/admin/rezome");
        }
    }
}