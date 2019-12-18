using Blog.DAL.Database;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Management
{
    public class ContactManagement
    {
        private ProjeContex database;

        public ContactManagement()
        {
            database = new ProjeContex();
        }

        public ContactPage GetContactPage()
        {
            var model = database.ContactPage.FirstOrDefault();

            return model;
        }
    }
}
