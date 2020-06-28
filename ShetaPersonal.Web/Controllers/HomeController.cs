using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShetaPersonal.Core.Covertor;
using ShetaPersonal.Core.DTO;
using ShetaPersonal.Core.Serevices.Interface;
using ShetaPersonal.Data.Model.Entities;
using ShetaPersonal.Web.Models;

namespace ShetaPersonal.Web.Controllers
{
    public class HomeController : Controller
    {
        private IService _service;
        private IAdminService _adminService;

        public HomeController(IService service, IAdminService adminService)
        {
            _service = service;
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            if (_adminService.IsActiveSite(1)!=true)
            {
                return Redirect("/SiteNotActive");
            }
            return View();
        }

        [Route("SiteNotActive")]
        public IActionResult SiteNotActive()
        {
            return View();
        }

        [HttpPost]
        public IActionResult tamas(TamasViewModel tamasView)
        {
            if (!ModelState.IsValid)
            {
                
            }
            TamasHa tamas = new TamasHa()
            {
                UserId = 1,
                name = tamasView.name,
                Email = tamasView.Email,
                Phone = tamasView.Phone,
                Massage = tamasView.Massage
            };
            _service.CreateTamas(tamas);

            ViewBag.success = true;

            return Redirect("/");
        }

        public IActionResult Savechange(int id)
        {
            _adminService.savechange();
            return Redirect("/admin/rezomedetails/" + id);
        }



        [HttpPost]
        public void DeleteDetail(int id)
        {
            _adminService.DeleteRezomedetail(id);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        [HttpPost]
        [Route("file-upload")]
        public IActionResult UploadImage(IFormFile upload, string CKEditorFuncNum, string CKEditor, string langCode)
        {
            if (upload.Length <= 0) return null;

            var fileName = Guid.NewGuid() + Path.GetExtension(upload.FileName).ToLower();



            var path = Path.Combine(
                Directory.GetCurrentDirectory(), "wwwroot/Site/Img",
                fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                upload.CopyTo(stream);

            }



            var url = $"{"/Img/"}{fileName}";


            return Json(new { uploaded = true, url });
        }


        [Route("logout")]
        public IActionResult logOut()
        {
            HttpContext.SignOutAsync();
            return Redirect("/admin");
        }
    }
}
