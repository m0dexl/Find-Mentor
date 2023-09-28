using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class QuestionsCreateDto
    {
        public int Form_Id { get; set; } = default!;
        public string Question_Text { get; set; } = default!;
    }
}
