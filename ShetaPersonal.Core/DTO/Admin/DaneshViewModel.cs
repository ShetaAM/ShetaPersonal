using System;
using System.Collections.Generic;
using System.Text;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.DTO.Admin
{
    public class DaneshViewModel
    {
        public List<Danesh> Daneshes { get; set; }
        public int CurrentPage { get; set; }   
        public int pagaCount { get; set; }   
    }
}
