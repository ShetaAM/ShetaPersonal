using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.DTO
{
    public class TamasViewModel
    {
        public string name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Massage { get; set; }
        public string MyEmail { get; set; }
        public string MyPhone { get; set; }
        public List<Social> Socials { get; set; }
    }

    public class ContactUsViewModel
    {
        
    }
}
