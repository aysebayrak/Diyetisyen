using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class DoctorManager : IDoctorService
    {
        IDoctorDal _doctorDal;
        public DoctorManager( IDoctorDal doctorDal)
        {
            _doctorDal = doctorDal;

        }
       //  [SecuredOperation("admin")]
        public IResult Add(Doctor doctor)
        {
            _doctorDal.Add(doctor);
            return new SuccessResult(Messages.DoctorAdd);
        }

        public IResult Delete(Doctor doctor)
        {
            _doctorDal.Delete(doctor);
            return new SuccessResult(Messages.DoctorDeleted);
        }

        public IDataResult<List<Doctor>> GetAll()
        {
            return new SuccessDataResult<List<Doctor>>(_doctorDal.GetAll());
        }

        public IResult Update(Doctor doctor)
        {
            _doctorDal.UpDate(doctor);
            return new SuccessResult(Messages.DoctorUpdated);
        }
    }
}
