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
    public class MentorRepository : Repository<Mentor, int>, IMentorRepository
    {
        public MentorRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        //public async Task<IList<Mentor>> GetAllAsync(Expression<Func<Mentor, bool>>? filter = null)
        //{
        //    // IQueryable oluştur
        //    IQueryable<Mentor> ticketQuery = PostgresContext.Set<Mentor>();

        //    // Eğer bir filtre belirtilmişse, filtreyi uygula
        //    if (filter != null)
        //    {
        //        ticketQuery = ticketQuery.Where(filter);
        //    }

        //    // Sonuçları çek ve liste olarak döndür
        //    var tickets = await ticketQuery.ToListAsync();
        //    return tickets;
        //}

        public async Task<IList<Mentor>> GetAllAsync(Expression<Func<Mentor, bool>>? filter = null)
        {
            var user = PostgresContext.Set<Mentor>();
            return filter == null
                ? await user.ToListAsync()
                : await user.Where(filter)
                .ToListAsync();
        }

        public async Task<IList<Mentor>> GetByMentorIdAsync(int id)
        {
            // Tüm biletleri çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }
    }
}
