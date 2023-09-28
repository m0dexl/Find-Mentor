using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class FormInfoDto
    {
        public int Id { get; set; } = default!;
        public string FormTitle { get; set; } = default!;
        public string FormDescription { get; set; } = default!;
    }
}
