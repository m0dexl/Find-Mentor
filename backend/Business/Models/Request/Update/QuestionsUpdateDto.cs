﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class QuestionsUpdateDto
    {
        public int Form_Id { get; set; }
        public string Question_Text { get; set; }
    }
}
