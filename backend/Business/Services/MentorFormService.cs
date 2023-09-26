using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Business.Services
{
    public class MentorFormService : BaseService<MentorForm, int, MentorFormInfoDto>, IMentorFormService
    {
        public MentorFormService(IUnitOfWork unitOfWork, IRepository<MentorForm, int> repository, IMapperHelper mapperHelper) : base(unitOfWork, repository, mapperHelper)
        {
        }
    }
}
