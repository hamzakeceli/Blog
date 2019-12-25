using Blog.Entity;
using Blog.Services;
using Blog.UI.Models;
using Blog.UI.Extensions;
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
            var about = aboutPageServices.GetAboutPage();
            var viewModel = about.GetAboutViewModel(); // about model çevirdik
           
                return View(viewModel);
            
           
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