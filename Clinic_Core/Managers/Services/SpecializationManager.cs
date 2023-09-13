using AutoMapper;
using Clinic_Common.Extensions;
using Clinic_Core.Managers.Interfaces;
using Clinic_DbModel.Models;
using Clinic_ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Core.Managers.Services
{
    public class SpecializationManager : ISpecializationManager
    {
        private clinic_dbContext _dbContext;
        private IMapper _mapper;
        public SpecializationManager(clinic_dbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<Specialization> GetAllSpecialties()
        {
            var result = _dbContext.Specializations.ToList();

            return result;
        }

        public List<Specialization> GetSpecialtiesBySpecificNum(int NumberOfSpecialties)
        {
            var result = _dbContext.Specializations.Take(NumberOfSpecialties).ToList();

            return result;
        }

        public SpectalizationModelView CreateSpecialty(SpectalizationModelView specialtyMV)
        {
            if (_dbContext.Specializations
                          .Any(a => a.SpecialtyName.Equals(specialtyMV.SpecialtyName,
                                    StringComparison.InvariantCultureIgnoreCase)))
            {
                throw new ServiceValidationException("Specialty already exist");
            }


            var specialty = _dbContext.Specializations.Add(new Specialization
            {
                SpecialtyName = specialtyMV.SpecialtyName
            }).Entity;

            _dbContext.SaveChanges();

            var result = _mapper.Map<SpectalizationModelView>(specialty);

            return result;
        }

        public SpectalizationModelView UpdateSpecialty(SpectalizationModelView currentSpecialty)
        {
            var specialty = _dbContext.Specializations
                        .FirstOrDefault(a => a.Id == currentSpecialty.Id)
                        ?? throw new ServiceValidationException("Specialty not found");

            specialty.SpecialtyName = currentSpecialty.SpecialtyName;

            _dbContext.SaveChanges();
            return _mapper.Map<SpectalizationModelView>(specialty);
        }
        public SpectalizationModelView DeleteSpecialty(SpectalizationModelView currentSpecialty)
        {
            var specialty = _dbContext.Specializations
                        .FirstOrDefault(a => a.Id == currentSpecialty.Id)
                        ?? throw new ServiceValidationException("specialty not exist");

            specialty.IsDelete = true;

            _dbContext.SaveChanges();
            return _mapper.Map<SpectalizationModelView>(specialty);
        }

    }
}

