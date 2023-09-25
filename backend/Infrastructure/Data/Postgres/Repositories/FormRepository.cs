using Infrastructure.Data.Postgres.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class FormRepository : Repository<Form, int>, IFormRepository
    {
        public FormRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Form>> GetAllAsync(Expression<Func<Form, bool>>? filter = null)
        {
            // IQueryable oluştur (IQueryable, veritabanı sorgularını veya başka türde sorguları oluşturmak ve sorgu sonuçlarını döndürmek için kullanılır.)
            IQueryable<Form> formQuery = PostgresContext.Set<Form>();

            // Eğer bir filtre belirtilmişse, filtreyi uygula
            if (filter != null)
            {
                formQuery = formQuery.Where(filter);
            }

            // Sonuçları çek ve liste olarak döndür
            var forms = await formQuery.ToListAsync();
            return forms;
        }

        public async Task<IList<Form>> GetByFormIdAsync(int id)
        {
            // Tüm formları çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }
    }
}

