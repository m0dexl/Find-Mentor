using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Mentor : Entity<int>
    {
        //public int Mentor_Id { get; set; }

        //public string Category_Id { get; set; }


        // user'dan gelen user_id yi foreign key olarak buraya alıp mentor id ile birebir ilişki
        public int User_Id { get; set; }
        [ForeignKey("User_Id")]
        public User User { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }

        public string Mentor_Description { get; set; }

        public bool isAvailable { get; set; } = true;

        public virtual ICollection<MentorCategory> MentorCategories { get; set; }
        public ICollection<Form> Forms { get; set; } = new List<Form>();
        //referanslar

    }
}