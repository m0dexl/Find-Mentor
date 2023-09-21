using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Mentor : Entity<int>
    {
        public int Mentor_Id { get; set; } = default!;
        public bool isValid { get; set; } = default!;
        public required int Category_Id { get; set; } = default!;


        //referanslar
        public required User User { get; set; } 

        public required Categories Categories { get; set; }

    }
}