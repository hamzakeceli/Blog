using Blog.Entity;
using Blog.Services;
using Blog.UI.Extensions;
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
            var aboutViewModel = aboutModel.GetAboutViewModel();
            return View(aboutViewModel);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var aboutModel = _aboutPageServices.GetAboutPage();

            var viewModel = aboutModel.GetAboutViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Edit(AboutViewModel aboutViewModel)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "tüm alanları doldurman zorunludurR.");
                return View();
            }
            var aboutPage = aboutViewModel.GetAboutPage();

            _aboutPageServices.UpdateAbout(aboutPage);

            return RedirectToAction("Index");
        }

    }
}