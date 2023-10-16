using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    ICategoryRepository Categories { get; }
    INoticeFormAnswerRepository NoticeFormAnswers { get; }
    INoticeRepository Notices { get; }


    Task<int> CommitAsync();
}