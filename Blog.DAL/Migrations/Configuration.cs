namespace Blog.DAL.Migrations
{
    using Blog.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
   // sealed:kalýtým yapamassýn  al kullan
    internal sealed class Configuration : DbMigrationsConfiguration<Blog.DAL.Database.ProjeContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Blog.DAL.Database.ProjeContex context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // her migration yapýldýðýnda çalýþýr.
            
            if(!context.AboutPage.Any())
            {
                var aboutPage = new AboutPage
                {
                    TitleName = "Örnek Baþlýk",
                    AboutDescription = "seed ile gelen içerik bu þekilde kullanýlýr",
                };
                context.AboutPage.Add(aboutPage);
                context.SaveChanges();
               

            }
        }
    }
}
