using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Tamasha
{
    [Authorize]
    public class DetailTamasModel : PageModel
    {
        private IAdminService _adminService;

        public DetailTamasModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.TamasHa Tamas { get; set; }
        public void OnGet(int id)
        {
            Tamas = _adminService.GetInfoTamas(id);
        }
    }
}