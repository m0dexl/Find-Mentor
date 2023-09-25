
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Mentor : Entity<int> // burası normalde entity idi. userdan kalıtım aldım. 24/09
    {
        //public int Mentor_Id { get; set; } burayı yeni değiştirdim artık userdan id aliyor. 24/09

        //public string Category_Id { get; set; }


        // user'dan gelen user_id yi foreign key olarak buraya alıp mentor id ile birebir ilişki
        //public int User_Id { get; set; }
        //[ForeignKey("User_Id")]
        //public User User { get; set; }
        // yeni değiştirdim. 24/09

        public User User { get; set; }


        public string Mentor_Description { get; set; }
        public MentorStatus Availability { get; set; } = MentorStatus.Available;

        //public bool isAvailable { get; set; } = true; yeni degistirdim alttaki icin. 24/09

        //public virtual ICollection<MentorCategory> MentorCategories { get; set; }
        public ICollection<MentorForm> Formlar { get; set; }

        // yeni sildim
        //public virtual ICollection<Categories> Categories { get; set; }

        public ICollection<MentorCategory> Kategoriler { get; set; }

        //referanslar

    }
}

public enum MentorStatus
{
    Available,
    Busy

}