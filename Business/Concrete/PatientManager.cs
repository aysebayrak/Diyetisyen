using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    partial class PatientManager : IPatientService
    {
        IPatientDal _patientDal;
        IDietService _dietService;
        public PatientManager(IPatientDal patientDal,IDietService dietService)
        {
            _patientDal = patientDal;
            _dietService = dietService;
        }
        [SecuredOperation("admin,patient.add")]
        public IResult Add(Patient patient)
        {
            IResult result = BusinessRules.Run(CheckIfDietCountOfPatientCorrect(patient.DietId));
            if (result != null)
            {
                return result;
            }
            _patientDal.Add(patient);
            return new SuccessResult(Messages.PatientAdded);
        }

        public IResult Delete(Patient patient)
        {
            _patientDal.Delete(patient);
            return new SuccessResult(Messages.PatientDeleted);

        }

        public IDataResult<List<Patient>> GetAll()
        {
            return new SuccessDataResult<List<Patient>>(_patientDal.GetAll(), Messages.PatientsListed);
        }

        public IDataResult<Patient> GetPatientById(int id)
        {
            return new SuccessDataResult<Patient>(_patientDal.Get(p => p.PatientId == id));
        }

        public IDataResult<List<PatientDetailDto>> GetPatientDetail(int patientId)
        {
            return new SuccessDataResult<List<PatientDetailDto>>(_patientDal.GetPatientDetails(patientDetail => patientDetail.PatientId == patientId));
        }

        public IDataResult<List<PatientDetailDto>> GetPatientDetails()
        {
            return new SuccessDataResult<List<PatientDetailDto>>(_patientDal.GetPatientDetails(), "");
        }

        public IResult Update(Patient patient)
        {
            var result = _patientDal.GetAll(p => p.DietId == patient.DietId).Count;
            if (result >= 1)
            {
                return new ErrorResult(Messages.PatientCountOfDietError);
            }
            _patientDal.Add(patient);
            return new SuccessResult(Messages.PatientUpdated);
        }

        private IResult CheckIfDietCountOfPatientCorrect(int dietId)
        {
            //bir hastada en fazla bir diyet eklenebilr


            var result = _patientDal.GetAll(p => p.DietId == dietId).Count;
            if (result >= 1)
            {
                return new ErrorResult(Messages.PatientCountOfDietError);
            }
            return new SuccessResult();
        }
    }
}
