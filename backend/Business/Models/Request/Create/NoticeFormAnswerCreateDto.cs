using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class NoticeFormAnswerCreateDto
    {
        public string Answer_Name { get; set; }
        public string Answer_Surname { get; set; }
        public string Answer_Email { get; set; }
        public int Answer_Phone { get; set; }
        public string Answer_AboutYourself { get; set; }
        public string Answer_YourGoal { get; set; }
        public string Answer_ToMentor { get; set; }
    }
}
