using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Rezome
    {
        public Rezome()
        {
            
        }
        [Key]
        public int RezomeId { get; set; }
        public int UserId { get; set; }
        public int VaziyatId { get; set; }

        [Display(Name = "نام رزومه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RezomeTitle { get; set; }

        [Display(Name = "تصویر رزومه")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RezomeImage { get; set; }

        [Display(Name = "لینک رزومه")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RezomeLink { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Description { get; set; }

        #region Region

        public virtual About About { get; set; }
        public virtual Vaziyat Vaziyat { get; set; }

        public virtual List<Rezomedetail> Rezomedetails { get; set; }
        public virtual List<RezomeTecs> RezomeTecses { get; set; }
        public virtual List<Gallery> Galleries { get; set; }
       

        #endregion
    }
}
