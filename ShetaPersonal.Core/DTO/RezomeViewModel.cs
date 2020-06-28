using System;
using System.Collections.Generic;
using System.Text;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.DTO
{
    public class RezomeViewModel
    {

        public List<Rezome> Rezomes { get; set; }   
        public List<RezomeTecs> RezomeTecses { get; set; }   
        public int vaziyatId { get; set; }   
        public string vaziyat { get; set; }   
    }

    public class ShoewRezomeViewModel
    {
        public Rezome Rezome { get; set; }
        public List<Rezomedetail> Rezomedetails { get; set; }
        public List<Gallery> Galleries { get; set; }
    }
}
