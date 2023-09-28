using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class FormQuestionCreateDto
    {
        public int FormId { get; set; } = default!;
        public int QuestionsId { get; set; } = default!;

    }
}
