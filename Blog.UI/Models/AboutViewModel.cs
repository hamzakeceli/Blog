using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Models
{
    public class AboutViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="Hakkımızda bilgisi göstermek içim vu alan zorunludur")]
        [MinLength(4,ErrorMessage="{0} için en az {1}  karakter gir")]
        [MaxLength(20,ErrorMessage ="{0}en fazla {1} karaker gir")]

        public string Title { get; set; }

        [Display(Name = "İçerik")]
        [Required(ErrorMessage = "Hakkımızda bilgisi içeriği buradan değiştirilmeli")]
        [AllowHtml] //html girişe izin ver
        public string Description { get; set; }


         // [StringLength(11,ErrorMessage ="tc {1} haneli olmak zorunda",MinimumLength =11)]
        // [EmailAddress]
        // [Phone]

    }
}