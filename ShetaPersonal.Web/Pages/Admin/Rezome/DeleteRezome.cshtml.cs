using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Rezome
{
    [Authorize]
    public class DeleteRezomeModel : PageModel
    {
        private IAdminService _adminService;

        public DeleteRezomeModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [BindProperty]
        public Data.Model.Entities.Rezome Rezome { get; set; }
        public void OnGet(int id)
        {
            Rezome = _adminService
                .GetInfoRezome(id);
            ViewData["rezomeid"] = id;
        }

        public IActionResult OnPost(int rezomeid)
        {
            _adminService.DeleteRezome(rezomeid);
            return RedirectToPage("index");
        }
    }
}