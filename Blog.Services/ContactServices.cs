using Blog.DAL.Management;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Services
{
    public class ContactServices
    {

        private ContactManagement contactManagement;

        public ContactServices()
        {
            contactManagement = new ContactManagement();
        }

        public ContactPage GetContactPage()
        {
            var model = contactManagement.GetContactPage();

            return model;
        }

    }
}
