using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CategoriesInfoDto
    {
        public int Id { get; set; } = default!;
        public string Category_Name { get; set; } = default!;
        public string Category_Description { get; set; } = default!;

        public MentorInfoDto Mentor { get; set; }

    }
}
