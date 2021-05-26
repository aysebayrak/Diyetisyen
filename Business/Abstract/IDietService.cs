using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
  public  interface IDietService
    {
        IDataResult<List<Diet>> GetAll();//işlem sonucu ve mesaj 
        IResult Add(Diet diet);
        IResult Update(Diet diet);
        IResult Delete(Diet diet);
      //  IDataResult<Diet> GetById(int dietId);

    }
}
