using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Web.Pages.Admin.Rezome
{
    [Authorize]
    public class EditRezomeModel : PageModel
    {
        private IAdminService _adminService;

        public EditRezomeModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [BindProperty]
        public Data.Model.Entities.Rezome Rezome { get; set; }

        [BindProperty]
        public List<Vaziyat> Vaziyats { get; set; }

        public void OnGet(int id)
        {
            Rezome = _adminService.GetInfoRezome(id);
            Vaziyats = _adminService.GetVaziyats();
        }

        public IActionResult OnPost(IFormFile ImgRezome)
        {
            if (!ModelState.IsValid)
            {
                return Page();

            }
            _adminService.UpdateRezome(Rezome, ImgRezome);
            return RedirectToPage("index");
        }
    }
}