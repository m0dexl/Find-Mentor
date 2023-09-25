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
    public class FormQuestionRepository : Repository<FormQuestion, int>, IFormQuestionRepository
    {
        public FormQuestionRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<FormQuestion>> GetAllAsync(Expression<Func<FormQuestion, bool>>? filter = null)
        {
            var user = PostgresContext.Set<FormQuestion>();
            return filter == null
                ? await user.ToListAsync()
                : await user.Where(filter)
                .ToListAsync();
        }

        public async Task<IList<FormQuestion>> GetByFormQuestionIdAsync(int id)
        {
            // Tüm biletleri çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }
    }
}
