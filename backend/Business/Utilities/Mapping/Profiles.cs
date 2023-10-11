using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>().ReverseMap();
        CreateMap<User, UserProfileDto>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<User, Models.Response.UserProfileDto>().ReverseMap(); //kullanıcı görüntüleme


        CreateMap<CategoriesCreateDto, Categories>().ReverseMap();
        CreateMap<CategoriesUpdateDto, Categories>().ReverseMap();
        CreateMap<Categories, CategoriesInfoDto>().ReverseMap();

        CreateMap<MentorCategoryCreateDto, MentorCategory>().ReverseMap();
        CreateMap<MentorCategoryUpdateDto, MentorCategory>().ReverseMap();
        CreateMap<MentorCategory, MentorCategoryInfoDto>().ReverseMap();


        CreateMap<MentorFormCreateDto, MentorForm>().ReverseMap();
        CreateMap<MentorFormUpdateDto, MentorForm>().ReverseMap();
        CreateMap<MentorForm, MentorFormInfoDto>().ReverseMap();

        CreateMap<FormCreateDto,Form>().ReverseMap();
        CreateMap<FormUpdateDto, Form>().ReverseMap();
        CreateMap<Form, FormInfoDto>().ReverseMap();

        CreateMap<FormQuestionCreateDto,FormQuestion>().ReverseMap();
        CreateMap<FormQuestionUpdateDto, FormQuestion>().ReverseMap();
        CreateMap<FormQuestion, FormQuestionInfoDto>().ReverseMap();

        CreateMap<QuestionsCreateDto,Questions>().ReverseMap();
        CreateMap<QuestionsUpdateDto,Questions>().ReverseMap();
        CreateMap<Questions,QuestionsInfoDto>().ReverseMap();






    }
}