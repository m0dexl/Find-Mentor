using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class NoticeCreateDto
    {
        public int MentorId { get; set; } // her mentörün 1 tane ilanı olacağı için unique olmalı ?
        public string NoticeTitle { get; set; }
        public string NoticeDescription { get; set; }
        public string NoticeCategoryName { get; set; }
        //public string NoticeMentorPhoto { get; set; }
    }
}
