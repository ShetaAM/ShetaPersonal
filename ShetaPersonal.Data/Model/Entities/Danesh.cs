using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Danesh
    {
        public Danesh()
        {
            
        }
        [Key]
        public int DId { get; set; }
        
        public int UserId { get; set; }

        [Display(Name = "نام دانش فردی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string DaneshName { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Tozihat { get; set; }

        [Display(Name = "آیکون")]
        public string Icon { get; set; }

        #region Region

        public virtual About About { get; set; }

        #endregion
    }
}
