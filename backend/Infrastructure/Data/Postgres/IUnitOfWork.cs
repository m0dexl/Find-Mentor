﻿using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users { get; }
    IUserTokenRepository UserTokens { get; }
    IFormRepository Forms { get; }
    IMentorFormRepository MentorForms { get; }

    Task<int> CommitAsync();
}