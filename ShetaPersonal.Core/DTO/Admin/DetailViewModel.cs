using System;
using System.Collections.Generic;
using System.Text;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.DTO.Admin
{
    public class DetailViewModel
    {
        public List<Rezomedetail> Rezomedetails { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
    }
}
