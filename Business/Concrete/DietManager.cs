using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DietManager : IDietService
    {
        IDietDal _dietDal;
      
        public DietManager(IDietDal dietDal)
        {
            _dietDal = dietDal;
        
        }
        public IResult Add(Diet diet)
        {
            _dietDal.Add(diet);
            return new SuccessResult(Messages.DietAdd);
        }

        public IResult Delete(Diet diet)
        {
            _dietDal.Delete(diet);
            return new SuccessResult(Messages.DietDeleted);
        }

        public IDataResult<List<Diet>> GetAll()
        {
            return new SuccessDataResult<List<Diet>>(_dietDal.GetAll());
        }

        public IDataResult<Diet> GetByDietId(int dietId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Diet diet)
        {
            _dietDal.UpDate(diet);
            return new SuccessResult(Messages.DietUpdated);
        }

        
    }
}
