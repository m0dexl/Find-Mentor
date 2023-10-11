using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MentorForm : Entity<int>
    {
        public int MentorId { get; set; }
        public User Mentor { get; set; }

        public int FormId {  get; set; }
        public Form Form { get; set; }
    }
}
