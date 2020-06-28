using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Gallary
{
    [Authorize]
    public class CreateGallaryModel : PageModel
    {
        private IAdminService _adminService;

        public CreateGallaryModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Gallery Gallery { get; set; }
        [BindProperty]
        public int Rezomeid { get; set; }

        public void OnGet(int id)
        {
            Rezomeid = id;
        }

        public IActionResult OnPost(IFormFile ImgGallery)
        {
            _adminService.CreateGallery(Gallery, ImgGallery);
            int rid = Gallery.RezomeId;
            return Redirect("/admin/gallary/" + rid);
        }
    }
}