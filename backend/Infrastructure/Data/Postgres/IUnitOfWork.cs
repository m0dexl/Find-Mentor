using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }

    ICategoriesRepository Categories { get; }

    IMentorCategoriesRepository MentorCategories { get; }

    Task<int> CommitAsync();
}