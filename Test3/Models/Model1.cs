using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using FakeData;
using Faker;

namespace Test3.Models
{
    public class Model1 : DbContext
    {
        //public  Model1()
        //    : base("name=Model1")
        //{
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //}
        public DbSet<Depo> Depo { get; set; }

        public Model1()
        {
            Database.SetInitializer(new VeritabaniOlustur());
        }
    }

  
        
}