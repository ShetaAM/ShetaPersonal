using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.DTO.Admin;
using ShetaPersonal.Core.Serevices.Interface;
using AboutViewModel = ShetaPersonal.Core.DTO.AboutViewModel;

namespace ShetaPersonal.Web.Pages.Admin.About
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private IAdminService _adminService;

        public IndexModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public AboutMeViewModel ViewModel { get; set; }
        [BindProperty]
        public TahsilatViewModel TahsilatViewModel { get; set; }
        public void OnGet(int pageid = 1, string filter = "")
        {
            ViewModel = _adminService.GetAllAbout(pageid, filter);
        }
    }
}