using Blog.DAL.Database;
using Blog.DAL.Management;
using Blog.Entity;

namespace Blog.Services
{
    public class AboutPageServices
    {
        private AboutManagement _aboutManagement;

        public AboutPageServices()
        {
            _aboutManagement = new AboutManagement();
        }

        public AboutPage GetAboutPage()
        {
            var model=_aboutManagement.GetAboutPage();
            return model;
        }
    }
}
