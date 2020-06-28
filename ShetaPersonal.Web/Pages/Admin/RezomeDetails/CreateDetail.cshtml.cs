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
    public class CreateDetailModel : PageModel
    {
        private IAdminService _adminService;

        public CreateDetailModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Rezomedetail RezomeDetails { get; set; }
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

           
            _adminService.CreateRezomedetail(RezomeDetails);
            int rid = RezomeDetails.RezomeId;
            return Redirect("/admin/rezomedetails/"+rid);
        }
    }
}