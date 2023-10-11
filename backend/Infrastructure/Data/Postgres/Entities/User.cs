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


    public string Mentor_Description { get; set; }

    public MentorStatus Availability { get; set; } = MentorStatus.Available;

    //public Mentor Mentor { get; set; }

    //public int phonenumber { get; set; } = default!;

    //public int Mentor_Id { get; set; } yeni cikardim 24/09
    //public Mentor Mentor { get; set; } yeni cikardim 24/09


    public ICollection<MentorCategory> CategoriesForMentor { get; set; }

    public ICollection<MentorForm> FormsForMentor { get; set; }


}

public enum UserType
{
    Admin,
    Mentor
}

public enum MentorStatus
{
    Available,
    Busy
}