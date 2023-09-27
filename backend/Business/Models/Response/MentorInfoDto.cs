using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MentorInfoDto
    {
        public string Mentor_Description { get; set; } = default!;

        public MentorStatus Availability { get; set; } = MentorStatus.Available;

        public UserProfileDto UserProfile { get; set; }
    }
}
