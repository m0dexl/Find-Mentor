using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class MentorCategory : Entity<int>
    {
        public int MentorId { get; set; }
        public User Mentor { get; set; }

        public int CategoryId { get; set; }
        public Categories Categories { get; set; }
    }
}
