using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class MentorCategoryConfiguration: IEntityTypeConfiguration<MentorCategory>
    {
        public void Configure(EntityTypeBuilder<MentorCategory> builder)
        {
            builder.HasKey(mc => new { mc.Mentor_Id, mc.Category_Id });

            builder.HasOne(mc => mc.Mentor)
                .WithMany(m => m.MentorCategories)
                .HasForeignKey(mc => mc.Mentor_Id);

            builder.HasOne(mc => mc.Categories)
                .WithMany(c => c.MentorCategory)
                .HasForeignKey(mc => mc.Category_Id);
        }
    }
}
