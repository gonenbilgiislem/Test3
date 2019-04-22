using Faker;
using System.Data.Entity;

namespace Test3.Models
{
    public class VeritabaniOlustur : CreateDatabaseIfNotExists<Model1>
    {
        protected override void Seed(Model1 model1)
        {
            for (int i = 0; i < 10; i++)
            {
                Depo depo = new Depo
                {
                    Ad = CompanyFaker.Name(),
                    Soyad = LocationFaker.Country()
                };
                model1.Depo.Add(depo);
            }

            model1.SaveChanges();
        }
    }
}