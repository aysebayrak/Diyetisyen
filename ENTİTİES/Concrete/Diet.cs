using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
   public    class Diet :IEntity
    {
        public int DietId { get; set; }
        public string DietName { get; set; }

    }
}
