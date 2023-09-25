using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MentorForm
    {
        public int MentorId { get; set; }
        public Mentor Mentor { get; set; }

        public int FormId {  get; set; }
        public virtual Form Form { get; set; }
    }
}
