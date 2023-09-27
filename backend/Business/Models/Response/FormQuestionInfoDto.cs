﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class FormQuestionInfoDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int QuestionsId { get; set; }

        public FormInfoDto FormInfoDto { get; set; }
        public QuestionsInfoDto QuestionsInfoDto { get; set; }
    }
}
