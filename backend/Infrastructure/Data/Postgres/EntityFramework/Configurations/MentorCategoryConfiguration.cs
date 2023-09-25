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
            // composite primary key
            builder.HasKey(mc => new { mc.MentorId, mc.CategoryId });

            // yeni sildim


            builder.HasOne(mc => mc.Mentor)
                .WithMany(m => m.Kategoriler)
                .HasForeignKey(mc => mc.MentorId);


            builder.HasOne(mc => mc.Categories)
                .WithMany(c => c.Mentorler)
                .HasForeignKey(cm => cm.CategoryId);
                
        }
    }
}
