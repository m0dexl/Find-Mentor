using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MentorCategory
    {
        public int Mentor_Id { get; set; }
        public Mentor Mentor { get; set; }

        public int Category_Id { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
