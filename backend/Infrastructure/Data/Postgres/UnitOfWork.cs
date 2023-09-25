using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;

    private UserRepository? _userRepository;
    private UserTokenRepository? _userTokenRepository;
    private CategoriesRepository? _categoriesRepository;
    private MentorCategoryRepository? _mentorCategoryRepository;
    private MentorRepository? _mentorRepository;
    private QuestionsRepository? _questionsRepository;
    private FormQuestionRepository? _formQuestionRepository;

    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public IUserRepository Users => _userRepository ??= new UserRepository(_postgresContext);
    public IUserTokenRepository UserTokens => _userTokenRepository ??= new UserTokenRepository(_postgresContext);
    public ICategoriesRepository Categories => _categoriesRepository ??= new CategoriesRepository(_postgresContext);

    public IMentorCategoriesRepository MentorCategories => _mentorCategoryRepository ??= new MentorCategoryRepository(_postgresContext);

    public IMentorRepository Mentor => _mentorRepository ??= new MentorRepository(_postgresContext);
    public IQuestionsRepository Questions => _questionsRepository ??= new QuestionsRepository(_postgresContext);
    public IFormQuestionRepository FormQuestion => _formQuestionRepository ??= new FormQuestionRepository(_postgresContext);


    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }

    public void Dispose()
    {
        _postgresContext.Dispose();
    }
}