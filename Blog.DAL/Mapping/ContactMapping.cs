using Blog.Entity;
using System.Data.Entity.ModelConfiguration;


namespace Blog.DAL.Mapping
{
    public class ContactMapping:EntityTypeConfiguration<ContactPage>
    {

        public ContactMapping()
        {
            ToTable("Contact", "blog");
        }
    }
}
