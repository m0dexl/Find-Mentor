using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MentorInfoDto
    {
        public int Id { get; set; }
        public string Mentor_Description { get; set; } = default!;

        public MentorStatus Availability { get; set; }

        public UserProfileDto UserProfile { get; set; }
    }
}
