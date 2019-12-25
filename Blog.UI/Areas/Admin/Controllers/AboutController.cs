using Blog.Entity;
using Blog.Services;
using Blog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Areas.Admin.Controllers
{
    public class AboutController : Controller
    {
        private AboutPageServices _aboutPageServices;

        public AboutController()
        {
            _aboutPageServices = new AboutPageServices();
        }

        // GET: Admin/About
        [HttpGet]
        public ActionResult Index()
        {
            var aboutModel = _aboutPageServices.GetAboutPage();
            return View(aboutModel);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var aboutModel = _aboutPageServices.GetAboutPage();

            var viewModel = new AboutViewModel
            {
                Title = aboutModel.TitleName,
                Description=aboutModel.AboutDescription
               
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(AboutPage aboutPage)
        {

            return RedirectToAction("Edit");
        }

    }
}