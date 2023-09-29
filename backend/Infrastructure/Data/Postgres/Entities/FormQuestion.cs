﻿using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class FormQuestion : Entity<int>
    {
        public int FormId { get; set; }
        public Form Form { get; set; }

        public int QuestionsId { get; set; }
        public Questions Questions { get; set; }
    }
}
