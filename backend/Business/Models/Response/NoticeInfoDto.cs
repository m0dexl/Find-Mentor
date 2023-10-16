using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class NoticeInfoDto
    {
        public int Id { get; set; } = default!;
        public int MentorUser_Id { get; set; } = default!; // her mentörün 1 tane ilanı olacağı için unique olmalı ?
        public string NoticeTitle { get; set; } = default!;
        public string NoticeDescription { get; set; } = default!;
        public string NoticeCategoryName { get; set; } = default!;
        //public string NoticeMentorPhoto { get; set; } = default!;
        public UserProfileDto User { get; set;} = default!;
        public ICollection<NoticeFormAnswerInfoDto> NoticeFormAnswers { get; set; } = default!;
    
    }
}
