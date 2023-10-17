using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class NoticeFormAnswerCreateDto
    {
        //public int MentorUser_Id { get; set; } = default!;
        public int Notice_Id { get; set; } = default!;
        public string Answer_Name { get; set; } = default!;
        public string Answer_Surname { get; set; } = default!;
        public string Answer_Email { get; set; } = default!;
        public string Answer_Phone { get; set; } = default!;
        public string Answer_AboutYourself { get; set; } = default!;
        public string Answer_YourGoal { get; set; } = default!;
        public string Answer_ToMentor { get; set; } = default!;
    }
}
