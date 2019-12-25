using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Blog.Entity
{
    [Table("About",Schema="blog")]  
    public class AboutPage
    {
        public int Id { get; set; }

      
        [Display(Name ="Başlık")] // uI görünesini istediğimiz text 
        public string TitleName { get; set; }
        [Display(Name = "İçerik")]
        public string AboutDescription { get; set; }

    }
}
