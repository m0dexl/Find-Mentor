using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Functional;

public class RegisterDto
{
    public string Email { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public string Mentor_Description { get; set; } = default!;
    public MentorStatus Availability { get; set; } = MentorStatus.Available;
    public UserType UserType { get; set; } = UserType.Mentor;


}