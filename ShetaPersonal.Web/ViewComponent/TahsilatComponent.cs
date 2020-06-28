using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShetaPersonal.Core.Serevices.Interface;

//using ShetaPersonal.Core.Servises.Interface;

namespace ShetaPersonal.Web.ViewComponent
{
    public class TahsilatComponent : Microsoft.AspNetCore.Mvc.ViewComponent
    {
        private IService _service;

        public TahsilatComponent(IService service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("Tahsilat", _service.GetTahsilats(1)));
        }
    }
}


