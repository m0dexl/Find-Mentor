using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities;

public class User : Entity<int>
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public byte[] PasswordSalt { get; set; } = default!;
    public byte[] PasswordHash { get; set; } = default!;
<<<<<<< HEAD
    public UserType UserType { get; set; } = UserType.Mentor;
=======
    public UserType UserType { get; set; }

    //public int phonenumber { get; set; } = default!;

    //public int Mentor_Id { get; set; }
    //public Mentor Mentor { get; set; }
>>>>>>> f1448dd9a5fc27ee98894099d5482d20635db8bb

}

public enum UserType
{
    Admin,
<<<<<<< HEAD
    Mentor
=======
    Mentor,
>>>>>>> f1448dd9a5fc27ee98894099d5482d20635db8bb
}