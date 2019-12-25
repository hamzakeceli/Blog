using Blog.Entity;
using Blog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.UI.Extensions
{
    public static class AboutExtension
    {
        public static AboutViewModel GetAboutViewModel(this AboutPage aboutPage)
        {
            var aboutViewModel = new AboutViewModel()
            {
                Title = aboutPage.TitleName,
                Description = aboutPage.AboutDescription,

            };

            return aboutViewModel;
        }

    }
}