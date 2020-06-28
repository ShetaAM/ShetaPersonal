using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class RezomeTecs
    {
        public RezomeTecs()
        {
            
        }

        [Key]
        public int RTId { get; set; }
        public int RezomeId { get; set; }

        [Display(Name = "نام تکنولوژی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string TecTitle { get; set; }

        #region Relation

        public virtual Rezome Rezome { get; set; }

        #endregion

    }
}
