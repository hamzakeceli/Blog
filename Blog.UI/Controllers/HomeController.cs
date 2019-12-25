using Blog.Entity;
using Blog.Services;
using Blog.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AboutPageServices aboutPageServices;
        private readonly ContactServices contactServices;

        public HomeController()
        {
            aboutPageServices = new AboutPageServices();
            contactServices = new ContactServices();


        }

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        public ActionResult About()
        {
           
            AboutPage about = aboutPageServices.GetAboutPage();
            if (about == null)
            {
                return View("_NotFound");
            }
            else
            {
                var viewModel = new AboutViewModel
                {
                    Title = about.TitleName,
                    Description = about.AboutDescription

                };


                return View(viewModel);
            }
           
        }
        [HttpGet]
        public ActionResult Contact()
        {
           
            ContactPage contact = contactServices.GetContactPage();
            if(contact==null)
            {
                return View("_NotFound");
            }

            return View(contact);
        }
    }
}