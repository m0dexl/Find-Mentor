﻿using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Categories : Entity<int>
    {
        public int Category_Id { get; set; }
        public string Category_Description { get; set;}
        public string Category_Photo { get; set; }

        public ICollection<MentorCategory> MentorCategory { get; set; }
        public Mentor Mentor { get; set; }
    }
}

// kategoriler default olarak dbde bulunack. Admin kategori ekleyip çıkartma işlemleri yapamayacak.
