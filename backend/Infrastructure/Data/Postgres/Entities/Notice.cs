using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Notice : Entity<int>
    {
        public string NoticeTitle { get; set; }
        public string NoticeDescription { get; set; }
        public string NoticeCategoryName { get; set; }
        //public string NoticeMentorPhoto { get; set; }

         //1'e 1 ilişkide ekstradan foreign key kolonuna ihtiyaç olmayacağından dolayı dependent entity'deki id kolonunun hem foreign key hem de primary key olarak kullanmayı tercih ediyoruz ve bu duruma özen gösterilidir diyoruz.
         public int MentorUser_Id { get; set; }
        //her mentörün 1 tane ilanı olacağı için unique olmalı ?


        public User MentorUser { get; set; }
        public ICollection<NoticeFormAnswer> NoticeFormAnswers { get; set; }
    }
}

// İlan entity'miz. Mentörün oluşturacağı ilanın entity'si