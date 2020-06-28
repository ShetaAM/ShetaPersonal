using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Gallary
{
    [Authorize]
    public class DeleteGallaryModel : PageModel
    {
        private IAdminService _adminService;

        public DeleteGallaryModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public ShetaPersonal.Data.Model.Entities.Gallery Gallery { get; set; }
        public void OnGet(int id)
        {
            Gallery = _adminService
                .GetInfoGallery(id);
            ViewData["detailid"] = id;
        }

        public IActionResult OnPost(int detailid)

        {
            _adminService.DeleteGallery(detailid);
            return Redirect("/admin/rezome");
        }
    }
}