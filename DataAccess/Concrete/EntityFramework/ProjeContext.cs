using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
   public class ProjeContext :DbContext
    {
        //context=veri tabanı ile kendi klaslarımızı ilişkilendirdiğimiz yapı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=YazilimMimarisi;Trusted_Connection=true");


        }
        public DbSet<Diet> Diets { get; set; }
        public DbSet<Disease > Diseases { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


        

    }
}
