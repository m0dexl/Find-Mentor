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

    public Mentor Mentor { get; set; }

    //public int phonenumber { get; set; } = default!;

    //public int Mentor_Id { get; set; } yeni cikardim 24/09
    //public Mentor Mentor { get; set; } yeni cikardim 24/09


}

public enum UserType
{
    Admin,
    Mentor
}