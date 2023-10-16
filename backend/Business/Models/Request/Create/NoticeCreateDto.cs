using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class NoticeCreateDto
    {
        public int MentorUser_Id { get; set; } = default!; // her mentörün 1 tane ilanı olacağı için unique olmalı ?
        public string NoticeTitle { get; set; } = default!;
        public string NoticeDescription { get; set; } = default!;
        public string NoticeCategoryName { get; set; } = default!;
        //public string NoticeMentorPhoto { get; set; }
    }
}
