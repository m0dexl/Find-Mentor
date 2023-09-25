using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Questions: Entity<int>
    {
        //public int Question_Id {  get; set; } entity den geliyor
        public string Question_Text { get; set; }

        public ICollection<FormQuestion> FormsForQuestions { get; set; }

        //public virtual ICollection<Form> Forms { get; set; }
        //public Form Form { get; set; }
    }
}
