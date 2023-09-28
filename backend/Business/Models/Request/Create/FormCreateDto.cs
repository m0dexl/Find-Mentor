using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class FormCreateDto
    {
        public string FormTitle { get; set; } = default!;
        public string FormDescription { get; set; } = default!;
    }
}
