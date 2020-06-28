using System;
using System.Collections.Generic;
using System.Text;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.DTO.Admin
{
   public class SocViewModel
    {
        public List<Social> Socials { get; set; }
        public int CurrentPage { get; set; }
        public int pagaCount { get; set; }
    }
}
