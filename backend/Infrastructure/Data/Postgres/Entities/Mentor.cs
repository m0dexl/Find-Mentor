using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Mentor : Entity<int>
    {
        [Required]
        public int mentorId { get; set; }

        public string name { get; set; }

        public string lastname { get; set; }

        public string mail { get; set; }

        public string password { get; set; }

        public int phonenumber { get; set; }

        [Required]
        public int categoryId { get; set; }

        [Required]
        public int degreeId { get; set; }

        public bool IsActive { get; set; }
    }
}