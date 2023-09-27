﻿using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        CreateMap<RegisterDto, User>();
        CreateMap<User, Models.Response.UserProfileDto>();

        CreateMap<MentorCreateDto, Mentor>();
        CreateMap<MentorUpdateDto, Mentor>();


        //aa
        CreateMap<CategoriesCreateDto, Categories>();
        CreateMap<CategoriesUpdateDto, Categories>();

        CreateMap<MentorCategoryCreateDto, MentorCategory>();
        CreateMap<MentorCategoryUpdateDto, MentorCategory>();



        CreateMap<MentorFormCreateDto, Mentor>();
        CreateMap<MentorFormUpdateDto, Mentor>();

        CreateMap<FormCreateDto,Form>();
        CreateMap<FormUpdateDto, Form>();

        CreateMap<FormQuestionCreateDto,FormQuestion>();
        CreateMap<FormQuestionUpdateDto, FormQuestion>();

        CreateMap<QuestionsCreateDto,Questions>();
        CreateMap<QuestionsUpdateDto,Questions>();

        CreateMap<UserUpdateDto, User>();
        CreateMap<Form, FormInfoDto>();
        CreateMap<Mentor, MentorInfoDto>();
        CreateMap<Categories, CategoriesInfoDto>();
        CreateMap<MentorCategory, MentorCategoryInfoDto>();
        CreateMap<MentorForm, MentorFormInfoDto>();
        CreateMap<FormQuestion, FormQuestionInfoDto>();
        CreateMap<Questions,QuestionsInfoDto>();





    }
}