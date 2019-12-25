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

        [Display(Name ="Başlık")]
        [Required(ErrorMessage ="başlık giriniz")]
        public string Title { get; set; }

        [Display(Name = "İçerik")]
        [AllowHtml]
        public string Description { get; set; }
    }
}