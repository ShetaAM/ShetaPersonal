using System;
using System.Collections.Generic;
using System.Text;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.DTO
{
    public class MaharatViewModel
    {
        public List<Maharat> maharats { get; set; }
        public List<Danesh> Daneshes { get; set; }
    }
}
