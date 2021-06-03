using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPatientDal : EfEntityRepositoryBase<Patient, ProjeContext>, IPatientDal
    {
        public List<PatientDetailDto> GetPatientDetails(Expression<Func<PatientDetailDto, bool>> filter = null)
        {
            using (ProjeContext context = new ProjeContext())
            {
                var result = from patient in context.Patients
                             join diet in context.Diets on patient.DietId equals diet.DietId
                             join disease in context.Diseases on patient.DiseaseId equals disease.DiseaseId

                             select new PatientDetailDto()
                             {
                                 PatientId = patient.PatientId,
                                 LastName = patient.LastName,
                                 FirstName = patient.FirstName,
                                 Tc = patient.Tc,
                                 Size = patient.Size,
                                 Age = patient.Age,
                                 Weight = patient.Weight,
                                 DietId = diet.DietId,
                                 DietName = diet.DietName,
                                 DiseaseId = disease.DiseaseId,
                                 DiseaseName = disease.DiseaseName

                             };

                return filter == null ? result.ToList() : result.Where(filter).ToList();


            }
        }
    }
}
