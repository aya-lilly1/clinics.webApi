using AutoMapper;
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
    public class ScheduletimingManager : IScheduletimingManager
    {
        private clinic_dbContext _dbContext;
        private IMapper _mapper;

        public ScheduletimingManager(clinic_dbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public ScheduletimingModelView AddScheduletiming(int DoctorId , ScheduletimingModelView scheduletiming)
        {
            var newScheduletiming = new ScheduletimingModelView
            {
                DoctorId = DoctorId,
                Day = scheduletiming.Day,
                StartTime = scheduletiming.StartTime,
                EndTime = scheduletiming.EndTime,
                DurationTime = scheduletiming.DurationTime,
            };
            var model = _mapper.Map<Scheduletiming>(newScheduletiming);
            _dbContext.Scheduletimings.Add(model);
            _dbContext.SaveChanges();
            return newScheduletiming;

        }
        public List<Scheduletiming>  GetScheduletimingForDoctor(int DoctorId)
        {
           var result = _dbContext.Scheduletimings.Where(x => x.DoctorId == DoctorId).ToList();
            return result;
        }


    }
}
