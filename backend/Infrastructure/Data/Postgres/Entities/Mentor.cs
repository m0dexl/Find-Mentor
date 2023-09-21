using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Mentor : Entity<int>
    {
<<<<<<< HEAD
        public int Mentor_Id { get; set; }

        //public string Category_Id { get; set; }

        public bool isValid { get; set; } = true;
        //public Categories Categories { get; set; } = default!;

        public ICollection<MentorCategory> MentorCategories { get; set; }
=======
        public int Mentor_Id { get; set; } = default!;
        public bool isValid { get; set; } = default!;
        public required int Category_Id { get; set; } = default!;


        //referanslar
        public required User User { get; set; } 

        public required Categories Categories { get; set; }

>>>>>>> f1448dd9a5fc27ee98894099d5482d20635db8bb
    }
}