using System.Data.Entity;

namespace Test3.Models
{
    public class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
            //Database.SetInitializer(new VeritabaniOlustur());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Depo> Depo { get; set; }
        public DbSet<Messages> Messages { get; set; }
    }
}