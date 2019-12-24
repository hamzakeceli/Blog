
using System.Web.Mvc;

namespace Blog.UI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}