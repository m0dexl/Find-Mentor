using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Categories
    {
        public int Category_Id { get; set; }
<<<<<<< HEAD
        public string Category_Name { get; set; }
        public string Category_Description { get; set;}
        public string Category_Photo { get; set; }

        public ICollection<MentorCategory> MentorCategory { get; set; }
        public Mentor Mentor { get; set; }
    }
}

// kategoriler default olarak dbde bulunacak. Admin kategori ekleyip çıkartma işlemleri yapamayacak.
=======
        public string Category_Name { get; set; } = default!;
        public string Category_Description { get; set; } = string.Empty;

        // kategorinin alt seceneklerini ileride ekleyebiliriz
    }
}

>>>>>>> f1448dd9a5fc27ee98894099d5482d20635db8bb
