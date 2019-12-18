namespace Blog.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cantactpageadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("blog.Contact", "ContactPageContent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("blog.Contact", "ContactPageContent");
        }
    }
}
