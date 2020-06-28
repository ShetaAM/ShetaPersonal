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
    public class EditgallaryModel : PageModel
    {
        private IAdminService _adminService;

        public EditgallaryModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Gallery Gallery { get; set; }
        
        int Rezomeid;
        public void OnGet(int id)
        {
            Gallery = _adminService.GetInfoGallery(id);
            Rezomeid = Gallery.RezomeId;
        }

        public IActionResult OnPost(IFormFile ImgGallery)
        {
            _adminService.EditGallery(Gallery, ImgGallery);
            int rid = Gallery.RezomeId;
            return Redirect("/admin/gallary/" + rid);
        }
    }
}