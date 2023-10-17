using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response;

public class UserProfileDto
{
    public int Id { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public UserType UserType { get; set; } = default!;

    //public NoticeInfoDto Notice { get; set; } = default!;
    //public ICollection<NoticeFormAnswerInfoDto> NoticeFormAnswers { get; set; } = default!;

}