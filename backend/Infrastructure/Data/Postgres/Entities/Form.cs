using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Form : Entity<int>
    {
        public int Form_Id {  get; set; }

        public int Form_Owner_Mentor_Id { get; set; }
         
        public virtual ICollection<Questions> Questions { get; set; }

        public Mentor Mentor { get; set; }
        
    }
}
