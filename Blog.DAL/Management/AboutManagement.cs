
using Blog.DAL.Database;
using Blog.Entity;
using System.Linq;

namespace Blog.DAL.Management
{
    public class AboutManagement
    {
        private ProjeContex database;

        public AboutManagement()
        {
            database = new ProjeContex();
        }
        public AboutPage GetAboutPage()
        {
            var aboutPage = database.AboutPage.FirstOrDefault();
            return aboutPage;
        }


    }
}
