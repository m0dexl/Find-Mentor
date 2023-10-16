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
    public class NoticeRepository: Repository<Notice,int>, INoticeRepository
    {
        public NoticeRepository(PostgresContext postgresContext) : base(postgresContext) 
        {
        
        }

        public virtual async Task<IList<Notice>> GetAllNoticeAsync(Expression<Func<Notice, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<Notice>().ToListAsync()
                : await PostgresContext.Set<Notice>().Where(filter).ToListAsync();
        }

        public async Task<IList<Notice>> GetNoticeByIdAsync(int id)
        {

            var notice = await PostgresContext.Notices
                .Where(n => n.Id == id)
                .ToListAsync();

            return notice;
        }
    }
}
