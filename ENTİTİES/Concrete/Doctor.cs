using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Doctor : IEntity     //  User   
    {
        public int  DoctorId { get; set; }
         // public  int  UserId { get; set; }
        public string FirstName { get; set; }

        public string Tc { get; set; }

        public string LastName { get; set; }
        public string Salary { get; set; } //maaş
       
    }
}
