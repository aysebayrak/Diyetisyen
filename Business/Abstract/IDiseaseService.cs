using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IDiseaseService
    {
        IDataResult<List<Disease>> GetAll();//işlem sonucu ve mesaj 
        IResult Add(Disease disease);
        IResult Update(Disease disease);
        IResult Delete(Disease disease);
    }
}
