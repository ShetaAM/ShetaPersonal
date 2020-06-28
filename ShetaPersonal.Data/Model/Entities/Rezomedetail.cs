using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Rezomedetail
    {
        public Rezomedetail()
        {
            
        }
        [Key]
        public int DetailId { get; set; }
        public int RezomeId { get; set; }

        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string DetailCaption { get; set; }

        [Display(Name = "مقدار")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string DetailValue { get; set; }

        #region Region

        public virtual Rezome Rezome { get; set; }

        #endregion
    }
}
