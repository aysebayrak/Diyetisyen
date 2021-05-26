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
    public class DiseaseManager : IDiseaseService
    {
        IDiseaseDal _diseaseDal;
        public DiseaseManager(IDiseaseDal diseaseDal)
        {
            _diseaseDal = diseaseDal;

        }
        public IResult Add(Disease disease)
        {
            _diseaseDal.Add(disease);
            return new SuccessResult(Messages.DiseaseAdd);
        }

        public IResult Delete(Disease disease)
        {
            _diseaseDal.Delete(disease);
            return new SuccessResult(Messages.DiseaseDeleted);
        }

        public IDataResult<List<Disease>> GetAll()
        {
            return new SuccessDataResult<List<Disease>>(_diseaseDal.GetAll());
        }

        public IResult Update(Disease disease)
        {
            _diseaseDal.UpDate(disease);
            return new SuccessResult(Messages.DiseaseUpdated);
        }
    }
}
