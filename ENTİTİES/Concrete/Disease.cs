using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public class Disease :IEntity  //hastalık
    {
        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }

    }
}
