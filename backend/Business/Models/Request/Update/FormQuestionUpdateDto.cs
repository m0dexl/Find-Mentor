using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class FormQuestionUpdateDto
    {
        public int Id { get; set; }
        public int FormId { get; set; }
        public int QuestionsId { get; set; }
    }
}
