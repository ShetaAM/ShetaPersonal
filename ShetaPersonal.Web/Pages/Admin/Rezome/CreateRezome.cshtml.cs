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
    public class CreateRezomeModel : PageModel
    {
        private IAdminService _adminService;

        public CreateRezomeModel(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [BindProperty]
        public Data.Model.Entities.Rezome Rezome { get; set; }

        [BindProperty]
        public List<Vaziyat> Vaziyats { get; set; }

        public void OnGet()
        {
            Vaziyats= _adminService.GetVaziyats();
        }
        public IActionResult OnPost(IFormFile ImgRezome )
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _adminService.CreateRezome(Rezome, ImgRezome);
            return RedirectToPage("index");
        }
    }
}