using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class CategoryInfoDto
    {
        public int Id { get; set; } = default!;
        public string Category_Name { get; set; } = default!;
        public string Category_Description { get; set; } = default!;
        //public string Category_Photo { get; set; } = default!;
    }
}
