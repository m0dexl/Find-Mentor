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
    public class NoticeConfiguration : BaseConfiguration<Notice, int>
    {
        public override void Configure(EntityTypeBuilder<Notice> builder)
        {
            base.Configure(builder);

            builder.HasKey(c => c.Id);

            builder.Property(n => n.MentorUser_Id).IsRequired();
            builder.HasIndex(n => n.MentorUser_Id).IsUnique();
            builder.Property(n => n.NoticeTitle).IsRequired();
            builder.HasIndex(n => n.NoticeTitle).IsUnique();
            builder.Property(n => n.NoticeDescription).IsRequired();
            builder.Property(n => n.NoticeCategoryName).IsRequired();
            //builder.Property(n => n.NoticeMentorPhoto).IsRequired();
        }
    }
}
