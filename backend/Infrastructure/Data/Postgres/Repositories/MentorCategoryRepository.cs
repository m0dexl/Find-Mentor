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
    public class MentorCategoryRepository : Repository<MentorCategory, int>, IMentorCategoriesRepository
    {
        public MentorCategoryRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<MentorCategory>> GetAllAsync(Expression<Func<MentorCategory, bool>>? filter = null)
        {
            // IQueryable oluştur
            IQueryable<MentorCategory> mentorCategoryQuery = PostgresContext.Set<MentorCategory>();

            // Eğer bir filtre belirtilmişse, filtreyi uygula
            if (filter != null)
            {
                mentorCategoryQuery = mentorCategoryQuery.Where(filter);
            }

            // Sonuçları çek ve liste olarak döndür
            var mentorCategories = await mentorCategoryQuery.ToListAsync();
            return mentorCategories;
        }

        public async Task<IList<MentorCategory>> GetByMentorCategoryIdAsync(int id)
        {
            // Tüm kategorileri çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }
    }
}
