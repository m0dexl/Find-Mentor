using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Request.Create
{
    public class MentorFormCreateDto
    {
        public int Id { get; set; } = default!;
        public int MentorId { get; set; } = default!;
        public int FormId { get; set; } = default!;
        public UserType UserType { get; set; } = UserType.Mentor;
    }
}
