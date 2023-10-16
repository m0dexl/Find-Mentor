using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface ICategoryRepository: IRepository<Category,int>
    {
        Task<IList<Category>> GetAllCategoryAsync(Expression<Func<Category, bool>>? filter = null);

        Task<IList<Category>> GetCategoryByIdAsync(int id);
    }
}
