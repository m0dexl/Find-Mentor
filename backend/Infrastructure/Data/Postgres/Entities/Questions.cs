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
<<<<<<< HEAD
        //public int Question_Id {  get; set; } entity den geliyor
=======
        public int Form_Id {  get; set; }
>>>>>>> 2369bb8f74374f008420511d6c190d0acda2ad21
        public string Question_Text { get; set; }

        public ICollection<FormQuestion> FormsForQuestions { get; set; }

        //public virtual ICollection<Form> Forms { get; set; }
        //public Form Form { get; set; }
    }
}
