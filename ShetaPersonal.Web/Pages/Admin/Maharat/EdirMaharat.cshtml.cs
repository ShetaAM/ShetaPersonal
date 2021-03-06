﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Pages.Admin.Maharat
{
    [Authorize]
    public class EdirMaharatModel : PageModel
    {
        private IAdminService _adminService;

        public EdirMaharatModel(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [BindProperty]
        public Data.Model.Entities.Maharat Maharat { get; set; }
        public void OnGet(int id)
        {
            Maharat = _adminService.GetInfoMaharat(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _adminService.EditMaharat(Maharat);
            return RedirectToPage("index");
        }
    }
}