using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class QuestionsInfoDto
    {
        public int Id { get; set; }
        public int Form_Id { get; set; }
        public string Question_Text { get; set; }
    }
}
