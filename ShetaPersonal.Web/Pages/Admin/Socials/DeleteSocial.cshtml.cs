using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Socials
{
    public class DeleteSocialModel : PageModel
    {
        private IAdminService _adminService;

        public DeleteSocialModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [BindProperty]
        public Data.Model.Entities.Social Social { get; set; }
        public void OnGet(int id)
        {
            Social = _adminService
                .GetInfoSocial(id);
            ViewData["socialid"] = id;
        }

        public IActionResult OnPost(int socialid)
        {
            _adminService.DeleteSocial(socialid);
            return RedirectToPage("index");
        }
    }
}