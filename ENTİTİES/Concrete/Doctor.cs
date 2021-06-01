using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Doctor :IEntity 
    {
        public int  DoctorId { get; set; }
         public  int  UserId { get; set; }
        public string Salary { get; set; } //maaş





   }
}
