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
                Id = aboutPage.Id,
                Title = aboutPage.TitleName,
                Description = aboutPage.AboutDescription,

            };

            return aboutViewModel;
        }
        public static AboutPage GetAboutPage(this AboutViewModel aboutViewModel)
        {
            var aboutPage = new AboutPage
            {
                Id = aboutViewModel.Id,
                TitleName = aboutViewModel.Title,
                AboutDescription = aboutViewModel.Description

            };

            return aboutPage;
        }

    }
}