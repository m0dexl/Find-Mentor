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
    public class NoticeFormAnswerRepository: Repository<NoticeFormAnswer, int>, INoticeFormAnswerRepository
    {
        public NoticeFormAnswerRepository(PostgresContext postgresContext) : base(postgresContext) 
        { 
        
        }

        public virtual async Task<IList<NoticeFormAnswer>> GetAllNoticeFormAnswerAsync(Expression<Func<NoticeFormAnswer, bool>>? filter = null)
        {
            return filter == null
                ? await PostgresContext.Set<NoticeFormAnswer>().ToListAsync()
                : await PostgresContext.Set<NoticeFormAnswer>().Where(filter).ToListAsync();
        }

        public async Task<IList<NoticeFormAnswer>> GetNoticeFormAnswerByIdAsync(int id)
        {

            var noticeformanswer = await PostgresContext.NoticeFormAnswers
                .Where(nfa => nfa.Id == id)
                .ToListAsync();

            return noticeformanswer;
        }
    }
}
