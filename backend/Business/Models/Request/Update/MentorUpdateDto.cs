﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class MentorUpdateDto
    {
        public string Mentor_Description { get; set; } = default!;

        public MentorStatus Availability { get; set; } = MentorStatus.Available;
    }
}