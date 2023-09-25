using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface ICategoriesRepository: IRepository<Categories,int>
    {
        Task<IList<Categories>> GetByCategoriesIdAsync(int id);
    }
}
