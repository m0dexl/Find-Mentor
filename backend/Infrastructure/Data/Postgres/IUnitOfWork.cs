using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IFormRepository Forms { get; }
    IMentorFormRepository MentorForms { get; }

    ICategoriesRepository Categories { get; }

    IMentorCategoriesRepository MentorCategories { get; }

    IFormQuestionRepository FormQuestion { get; }
    IMentorRepository Mentor { get; }
    IQuestionsRepository Questions { get; }

    Task<int> CommitAsync();
}