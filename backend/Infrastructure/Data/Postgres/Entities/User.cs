using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
    public UserType UserType { get; set; } = UserType.Mentor;

    public Notice Notice { get; set; }
    public ICollection<NoticeFormAnswer> NoticeFormAnswers { get; set; }

}

public enum UserType
{
    Admin,
    Mentor
}

// kullanıcı entity'miz. Bu entity aynı zamanda mentörümüze eşit diyebiliriz.