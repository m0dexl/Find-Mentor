using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class CategoryRepository: Repository<Category, int>, ICategoryRepository
    {
        public CategoryRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }

        public virtual async Task<IList<Category>> GetAllCategoryAsync(Expression<Func<Category, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Category>().ToListAsync()
                : await PostgresContext.Set<Category>().Where(filter).ToListAsync();
        }

        public async Task<IList<Category>> GetCategoryByIdAsync(int id)
        {

            var category = await PostgresContext.Categories
                .Where(c => c.Id == id)
                .ToListAsync();

            return category;
        }
    }
}
