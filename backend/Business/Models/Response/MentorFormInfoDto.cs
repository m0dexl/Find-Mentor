using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Models.Response
{
    public class MentorFormInfoDto
    {
        public int Id { get; set; } = default!;
        public int MentorId { get; set; } = default!;
        public int FormId { get; set; } = default!;
        

        //Mentor bilgilerine ulaşmak için nesne oluşturduk
        public UserProfileDto Mentor { get; set; }
        public FormInfoDto FormInfo { get; set; }
    }
}
