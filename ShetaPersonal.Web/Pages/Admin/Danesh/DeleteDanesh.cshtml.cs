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
    public class DeleteDaneshModel : PageModel
    {
        private IAdminService _adminService;

        public DeleteDaneshModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [BindProperty]
        public Data.Model.Entities.Danesh Danesh { get; set; }
        public void OnGet(int id)
        {
            Danesh = _adminService
                .GetInfoDanesh(id);
            ViewData["daneshid"] = id;
        }

        public IActionResult OnPost(int daneshid)
        {
            _adminService.DeleteDanesh(daneshid);
            return RedirectToPage("index");
        }
    }
}