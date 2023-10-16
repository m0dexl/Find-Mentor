using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories.Interface
{
    public interface INoticeFormAnswerRepository: IRepository<NoticeFormAnswer,int>
    {
        Task<IList<NoticeFormAnswer>> GetAllNoticeFormAnswerAsync(Expression<Func<NoticeFormAnswer, bool>>? filter = null);
        Task<IList<NoticeFormAnswer>> GetNoticeFormAnswerByIdAsync(int id);
    }
}
