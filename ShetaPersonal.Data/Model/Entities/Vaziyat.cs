using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Vaziyat
    {
        public Vaziyat()
        {
            
        }
        [Key]
        public int VaziyatId { get; set; }

        [Display(Name = "عنوان وضعیت")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Title { get; set; }

        #region Relation

        public virtual List<Rezome>Rezomes { get; set; }
        #endregion
    }
}
