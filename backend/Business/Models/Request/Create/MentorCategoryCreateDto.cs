﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class MentorCategoryCreateDto
    {
        public int Id { get; set; }
        public int MentorId { get; set; }
        public int CategoryId { get; set; }
    }
}
