using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
   public class PatientDetailDto :IDto
    {
        public int PatientId { get; set; }
        public int DietId { get; set; }
        public string DietName { get; set; }
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }

        public string FirstName { get; set; }

        public string Tc { get; set; }

        public string LastName { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }

    }
}
