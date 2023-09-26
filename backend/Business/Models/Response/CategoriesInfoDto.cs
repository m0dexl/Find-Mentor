using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CategoriesInfoDto
    {
        public string Category_Name { get; set; }
        public string Category_Description { get; set; }

        public MentorInfoDto Mentor { get; set; }

    }
}
