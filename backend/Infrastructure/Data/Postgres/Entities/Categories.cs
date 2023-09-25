using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Categories : Entity<int>
    {
        //public int Category_Id { get; set; } entity den geliyor
        //public int Category_Id { get; set; }

        public string Category_Name { get; set; }
        public string Category_Description { get; set;}
        //public string Category_Photo { get; set; } sonrasi icin

        public ICollection<MentorCategory> MentorsForCategory { get; set; }

        //public virtual ICollection<Mentor> Mentor { get; set; }
        //public virtual ICollection<Form> Forms { get; set; }

    }
}


