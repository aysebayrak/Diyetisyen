 using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
  public  class Patient :   IEntity
    {
        public int PatientId { get; set; }
        ////   public int UserId { get; set; }
        public string FirstName { get; set; }

        public string Tc { get; set; }

        public string LastName { get; set; }
        public int DietId { get; set; }
        public int DiseaseId { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string  Age { get; set; }


    }
}
