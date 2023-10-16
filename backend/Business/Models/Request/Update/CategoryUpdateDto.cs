using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class CategoryUpdateDto
    {
        public string Category_Name { get; set; } = default!;
        public string Category_Description { get; set; } = default!;
        //public string Category_Photo { get; set; } = default!;

    }
}
