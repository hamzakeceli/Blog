using System.ComponentModel.DataAnnotations.Schema;


namespace Blog.Entity
{
    [Table("About",Schema="blog")]  
    public class AboutPage
    {
        public int Id { get; set; }

        public string TitleName { get; set; }

        public string AboutDescription { get; set; }

    }
}
