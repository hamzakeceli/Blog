using Blog.DAL.Mapping;
using Blog.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DAL.Database
{
    public class ProjeContex:DbContext
    {
        public ProjeContex()
            //:base("server=; Database=; Uid=; Pwd=")
            //:base("server=; Database=; Trusted_Connection=True;")
            : base("defaultConnection")  //wepconfig alıyor
        {
           // Database.Connection.ConnectionString = @"server=; Database=; Uid=; Pwd=";

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ContactMapping());

            //s takısı koyma tabloları getirirken
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<AboutPage> AboutPage { get; set; }

        public DbSet<ContactPage> ContactPage { get; set;}

       


    }
}
