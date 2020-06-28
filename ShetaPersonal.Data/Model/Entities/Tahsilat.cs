using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Tahsilat
    {
        public Tahsilat()
        {
            
        }
        [Key]
        public int TahsilatId { get; set; }
        public int UserId { get; set; }
        [Display(Name = "نام دانشگاه'")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Daneshgah { get; set; }

        [Display(Name = "نام رشته")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Reshte { get; set; }

        [Display(Name = "نام گرایش")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string gerayesh { get; set; }

        [Display(Name = "مقطع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string maghta { get; set; }

        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string StartTime { get; set; }

        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string EndTime { get; set; }
        
        #region Region

        public virtual About About { get; set; }

        #endregion
    }
}
