using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class NoticeFormAnswer: Entity<int>
    {
        public int Mentor_Id { get; set; }
        public int Notice_Id { get; set; }
        public string Answer_Name {  get; set; }
        public string Answer_Surname { get; set; }
        public string Answer_Email { get; set; }
        public int Answer_Phone { get; set; }
        public string Answer_AboutYourself { get; set; }
        public string Answer_YourGoal { get; set; }
        public string Answer_ToMentor { get; set; }

        public User User { get; set; }
        public Notice Notice { get; set; }
    }
}

// ad, soyad, mail, telefon, Kendinden bahseder misin?, Nelerde gelişmek istiyorsun?,  Mentora soruların var mı?
// frontta kullanıcıya soracağımız sorular