using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.RezomeDetails
{
    [Authorize]
    public class EditDetailModel : PageModel
    {
        private IAdminService _adminService;

        public EditDetailModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Rezomedetail RezomeDetails { get; set; }

        private int Rezomeid;
        public void OnGet(int id)
        {
            RezomeDetails = _adminService.GetInfoRezomedetail(id);
            Rezomeid = RezomeDetails.RezomeId;
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.EditRezomedetail(RezomeDetails);
            int rid = RezomeDetails.RezomeId;
            return Redirect("/admin/rezomedetails/"+ rid );
        }
    }
}