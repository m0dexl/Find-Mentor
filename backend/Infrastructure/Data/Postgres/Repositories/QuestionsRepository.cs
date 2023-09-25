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
    public class QuestionsRepository : Repository<Questions, int>, IQuestionsRepository
    {
        public QuestionsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Questions>> GetAllAsync(Expression<Func<Questions, bool>>? filter = null)
        {
            var user = PostgresContext.Set<Questions>();
            return filter == null
                ? await user.ToListAsync()
                : await user.Where(filter)
                .ToListAsync();
        }

        public async Task<IList<Questions>> GetByQuestionsIdAsync(int id)
        {
            // Tüm biletleri çekmek için GetAllAsync'i kullanabiliriz
            return await GetAllAsync();
        }
    }
}
