using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public UserType UserType { get; set; } = default!;

    public string Mentor_Description { get; set; } = default!;

    public MentorStatus Availability { get; set; } = default!;

    public MentorCategoryInfoDto CategoriesForMentor { get; set; }

    public MentorFormInfoDto FormsForMentor { get; set; }

}