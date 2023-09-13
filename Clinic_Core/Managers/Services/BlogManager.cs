using AutoMapper;
using Clinic_Core.Managers.Interfaces;
using Clinic_DbModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Core.Managers
{
    public class BlogManager : IBlogManager
    {
        private clinic_dbContext _dbContext;
        private IMapper _mapper;

        public BlogManager(clinic_dbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
    }
}
