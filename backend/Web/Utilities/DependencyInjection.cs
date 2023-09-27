using Business.Services;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Security.Auth.Jwt;
using Business.Utilities.Security.Auth.Jwt.Interface;
using Business.Utilities.Validation;
using Business.Utilities.Validation.Interface;
using Core.Utilities.Mail;
using Infrastructure.Data.Postgres;

namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddScoped<IClaimHelper, ClaimHelper>();
        serviceCollection.AddScoped<IAuthService, AuthService>();
        serviceCollection.AddScoped<ICategoriesService, CategoriesService>();
        serviceCollection.AddScoped<IFormService, FormService>();
        serviceCollection.AddScoped<IMentorCategoryService, MentorCategoryService>();
        serviceCollection.AddScoped<IMentorFormService, MentorFormService>();
        serviceCollection.AddScoped<IMentorService, MentorService>();
        serviceCollection.AddScoped<IQuestionsService, QuestionsService>();
        serviceCollection.AddScoped<IUserService, UserService>();

    }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
        serviceCollection.AddSingleton<IMailHelper, MailHelper>();
    }

    public static void AddMyTransient(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddTransient<IMapperHelper, MapperHelper>();
        serviceCollection.AddTransient<IValidationHelper, ValidationHelper>();
        serviceCollection.AddTransient<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddTransient<IHashingHelper, HashingHelper>();
        serviceCollection.AddTransient<IMailHelper, MailHelper>();

        serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddTransient<IClaimHelper, ClaimHelper>();
        serviceCollection.AddTransient<IAuthService, AuthService>();
        serviceCollection.AddTransient<ICategoriesService, CategoriesService>();
        serviceCollection.AddTransient<IFormService, FormService>();
        serviceCollection.AddTransient<IMentorCategoryService, MentorCategoryService>();
        serviceCollection.AddTransient<IMentorFormService, MentorFormService>();
        serviceCollection.AddTransient<IMentorService, MentorService>();
        serviceCollection.AddTransient<IQuestionsService, QuestionsService>();
        serviceCollection.AddTransient<IUserService, UserService>();
    }
}