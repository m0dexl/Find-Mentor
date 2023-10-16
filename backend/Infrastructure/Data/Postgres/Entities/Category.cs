using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Category : Entity<int>
    {
        public string Category_Name { get; set; }
        public string Category_Description { get; set; }
        //public string Category_Photo { get; set; }
    }
}


// Kategori entity'miz. Mentör ilan oluştururken burada ki kategorilerden birini seçip ilanı o kategoriye oluşturabilecek.
// Aynı zamanda ilanlar kategoriye göre filtrelenebilecek.