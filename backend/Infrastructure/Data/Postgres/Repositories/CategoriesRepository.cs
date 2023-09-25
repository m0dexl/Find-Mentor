using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class CategoriesRepository : Repository<Categories, int>, ICategoriesRepository
    {
        public CategoriesRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Categories>> GetAllAsync(Expression<Func<Categories, bool>>? filter = null)
        {
            // IQueryable oluştur
            IQueryable<Categories> categoriesQuery = PostgresContext.Set<Categories>();

            // Eğer bir filtre belirtilmişse, filtreyi uygula
            if (filter != null)
            {
                categoriesQuery = categoriesQuery.Where(filter);
            }

            // Sonuçları çek ve liste olarak döndür
            var categories = await categoriesQuery.ToListAsync();
            return categories;
        }

        public async Task<IList<Categories>> GetByCategoriesIdAsync(int id)
        {
            // Tüm kategorileri çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }

    }
}