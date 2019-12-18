namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seeddeneme : DbMigration
    { 

        //dowdan sonra çalýþýr
        public override void Up()
        {
            CreateTable(
                "blog.About",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                        AboutDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "blog.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TitleName = c.String(),
                        FullName = c.String(),
                        EmailAdress = c.String(),
                        PhoneNumber = c.String(),
                        LinkedInProfile = c.String(),
                        GithubProfile = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        //önce down metodu çalýþýr 
        public override void Down()
        {
            DropTable("blog.Contact");
            DropTable("blog.About");
        }
    }
}
