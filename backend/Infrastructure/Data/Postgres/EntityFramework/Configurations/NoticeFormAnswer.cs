using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class NoticeFormAnswerConfiguration : BaseConfiguration<NoticeFormAnswer, int>
    {
        public override void Configure(EntityTypeBuilder<NoticeFormAnswer> builder)
        {
            base.Configure(builder);

            builder.HasKey(c => c.Id);

            builder.Property(n => n.MentorUser_Id).IsRequired();
            builder.Property(n => n.Notice_Id).IsRequired();
            builder.Property(n => n.Answer_Name).IsRequired();
            builder.Property(n => n.Answer_Surname).IsRequired();
            builder.Property(n => n.Answer_Email).IsRequired();
            builder.Property(n => n.Answer_Phone).IsRequired();
            builder.Property(n => n.Answer_AboutYourself).IsRequired();
            builder.Property(n => n.Answer_YourGoal).IsRequired();
            builder.Property(n => n.Answer_ToMentor).IsRequired();


            //builder.HasOne(nfa => nfa.MentorUser)
            //    .WithMany(u => u.NoticeFormAnswers)
            //    .HasForeignKey(nfa => nfa.MentorUser_Id);

            builder.HasOne(nfa => nfa.Notice)
                .WithMany(n => n.NoticeFormAnswers)
                .HasForeignKey(nfa => nfa.Notice_Id);
        }
    }
}
