﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.DTO.Admin;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.RezomeTechnologi
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
        public TechnologiViewModel DetailViewModel { get; set; }

        [BindProperty]
        public int RezomeId { get; set; }
        public void OnGet(int id, int pageid = 1, string filter = "")
        {
            DetailViewModel = _adminService.GetAllTechnologi(id, pageid, filter);
            RezomeId = id;
        }
    }
}