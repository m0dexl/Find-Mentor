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
    public class MentorFormRepository : Repository<MentorForm, int>, IMentorFormRepository
    {
        public MentorFormRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<MentorForm>> GetAllAsync(Expression<Func<MentorForm, bool>>? filter = null)
        {
            // IQueryable oluştur
            IQueryable<MentorForm> mentorformQuery = PostgresContext.Set<MentorForm>();

            // Eğer bir filtre belirtilmişse, filtreyi uygula
            if (filter != null)
            {
                mentorformQuery = mentorformQuery.Where(filter);
            }

            // Sonuçları çek ve liste olarak döndür
            var mentorforms = await mentorformQuery.ToListAsync();
            return mentorforms;
        }

        public async Task<IList<MentorForm>> GetByTicketIdAsync()
        {
            // Tüm formları çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }
    }
}

