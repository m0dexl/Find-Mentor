﻿using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Form : Entity<int>
    {
        //public int Form_Id {  get; set; }

        //public int Form_Owner_Mentor_Id { get; set; }


        //public virtual ICollection<Questions> QuestionsV { get; set; } = new List<Questions>();

        //public virtual ICollection<Questions> QuestionsLıst { get; set; } = new List<Questions>();
        public string FormTitle { get; set; }   
        public string FormDescription { get; set; }

        public ICollection<MentorForm> MentorsForForm { get; set; }

        public ICollection<FormQuestion> QuestionsForForms { get; set; }
        //public Questions Questions { get; set; }
        
    }
}
