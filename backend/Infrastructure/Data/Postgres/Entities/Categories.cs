﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Categories
    {
        public int Category_Id { get; set; }
        public string Category_Name { get; set; } = default!;
        public string Category_Description { get; set; } = string.Empty;

        // kategorinin alt seceneklerini ileride ekleyebiliriz
    }
}

