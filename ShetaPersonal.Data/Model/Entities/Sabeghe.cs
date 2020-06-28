using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Sabeghe
    {
        public Sabeghe()
        {
            
        }
        [Key]
        public int SId { get; set; }
        public int UserId { get; set; }

        [Display(Name = "نام سابقه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Stitle { get; set; }

        [Display(Name = "تاریخ شروع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string StartTime { get; set; }

        [Display(Name = "تاریخ پایان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string EndTime { get; set; }
        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "آیکون")]
        public string Icon { get; set; }


        #region Region

        public virtual About About { get; set; }

        #endregion
    }
}
