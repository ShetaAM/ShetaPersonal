using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShetaPersonal.Data.Model.Entities
{
    public class Social
    {
        public Social()
        {

        }

        [Key]
        public int SociaId { get; set; }
        public int UserId { get; set; }

        [Display(Name = "نام شبکه اجتماعی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string SocialName { get; set; }

        [Display(Name = "آیکون")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string SocialIcon { get; set; }

        [Display(Name = "لینک شبکه")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string SocialLink { get; set; }

        #region Relation

        public virtual About About { get; set; }

        #endregion
    }
}
