using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IPatientService
    {
        IDataResult<List<Patient>> GetAll();//işlem sonucu ve mesaj 
        IResult Add(Patient patient);
        IResult Update(Patient patient);
        IResult Delete(Patient patient);
    }
}
