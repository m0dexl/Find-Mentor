﻿using Infrastructure.Data.Postgres.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class UserCreateDto
    {
        public string Email { get; set; } = default!;
        public string UserName { get; set; } = default!;
        public string FullName { get; set; } = default!;
        public byte[] PasswordSalt { get; set; } = default!;
        public byte[] PasswordHash { get; set; } = default!;
        public UserType UserType { get; set; }

        public string Mentor_Description { get; set; } = default!;

        public MentorStatus Availability { get; set; } = MentorStatus.Available;
    }
}
