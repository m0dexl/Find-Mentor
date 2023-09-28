using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class MentorCategoryInfoDto
    {
        public int Id { get; set; } = default!;
        public int MentorId { get; set; } = default!;
        public int CategoryId { get; set; } = default!;

        public MentorInfoDto MentorInfoDto { get; set; }
        public CategoriesInfoDto CategoriesInfoDto { get; set; }
        
    }
}
