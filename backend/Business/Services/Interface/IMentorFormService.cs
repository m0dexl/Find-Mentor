﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Base.Interface;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Services.Interface
{
    public interface IMentorFormService : IBaseService<MentorForm, int, MentorFormInfoDto>
    {
    }
}
