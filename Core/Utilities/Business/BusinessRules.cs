using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Business
{
   public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)//params =virgül ile istediğim kadar Iresult verebilirim 
        {// logic =yazılan kurallar demek 
            foreach (var logic in logics)//her bir iş kuralını gez
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
