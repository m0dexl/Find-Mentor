using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Mentor : Entity<int>
    {
        public int Mentor_Id { get; set; }

        //public string Category_Id { get; set; }

        public bool isValid { get; set; } = true;
        //public Categories Categories { get; set; } = default!;

        public ICollection<MentorCategory> MentorCategories { get; set; }
    }
}