﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class NoticeFormAnswerInfoDto
    {
        public int Id { get; set; } = default!;
        public string Answer_Name { get; set; } = default!;
        public string Answer_Surname { get; set; } = default!;
        public string Answer_Email { get; set; } = default!;
        public int Answer_Phone { get; set; } = default!;
        public string Answer_AboutYourself { get; set; } = default!;
        public string Answer_YourGoal { get; set; } = default!;
        public string Answer_ToMentor { get; set; } = default!;
        public int MentorUser_Id { get; set; } = default!;
        public int Notice_Id { get; set; } = default!;

        public UserProfileDto User { get; set; } = default!;
        public NoticeInfoDto Notice { get; set; } = default!;

    }
}
