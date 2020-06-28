using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Maharat
    {
        public Maharat()
        {
            
        }
        [Key]
        public int MId { get; set; }
        [Display(Name = "نام مهارت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int UserId { get; set; }
        public string Title { get; set; }

        [Display(Name = "درصد توانایی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int Persent { get; set; }

        #region Region

        public virtual About About{ get; set; }

        #endregion

    }
}
