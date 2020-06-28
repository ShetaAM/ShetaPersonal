using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShetaPersonal.Core.DTO;
using ShetaPersonal.Core.Serevices.Interface;

namespace ShetaPersonal.Web.Controllers
{
    public class RezomeController : Controller
    {
        private IService _service;

        public RezomeController(IService service)
        {
            _service = service;
        }

        [Route("ShowRezome/{id}")]
        public IActionResult ShowRezome(int id)
        {
            return View(_service.GetRezomeInformation(id));
        }
    }
}
