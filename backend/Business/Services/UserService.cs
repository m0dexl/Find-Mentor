using Business.Models.Response;
using Business.Services.Base;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : BaseService<User, int, UserProfileDto>
    {
        public UserService(IUnitOfWork unitOfWork, IRepository<User, int> repository, IMapperHelper mapperHelper) : base(unitOfWork, repository, mapperHelper)
        {
        }
    }
}
