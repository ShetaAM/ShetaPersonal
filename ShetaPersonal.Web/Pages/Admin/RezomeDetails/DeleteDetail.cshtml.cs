using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShetaPersonal.Data.Model.Entities;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.RezomeDetails
{
    [Authorize]
    public class DeleteDetailModel : PageModel
    {
        private IAdminService _adminService;

        public DeleteDetailModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public ShetaPersonal.Data.Model.Entities.Rezomedetail RezomeDetail { get; set; }
        public void OnGet(int id)
        {
            RezomeDetail = _adminService
                .GetInfoRezomedetail(id);
            ViewData["detailid"] = id;
        }

        public IActionResult OnPost(int detailid)

        {
            _adminService.DeleteRezomedetail(detailid);
            return Redirect("/admin/rezome");
        }
    }
}