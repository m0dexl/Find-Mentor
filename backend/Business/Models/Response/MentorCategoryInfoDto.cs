using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MentorCategoryInfoDto
    {
        public int Id { get; set; }
        public int MentorId { get; set; }
        public int CategoryId { get; set; }

        public MentorInfoDto MentorInfoDto { get; set; }
        public CategoriesInfoDto CategoriesInfoDto { get; set; }
        
    }
}
