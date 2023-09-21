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
    public class MentorConfiguration: IEntityTypeConfiguration<Mentor>
    {
        public void Configure(EntityTypeBuilder<Mentor> builder)
        {
            builder.HasKey(x => x.mentorId);
            builder.Property(x => x.mail).IsRequired();
            builder.HasIndex(x => x.mail).IsUnique();
            builder.Property(x => x.name).IsRequired();
            builder.HasIndex(x => x.name).IsUnique();
            builder.Property(x => x.lastname).IsRequired();
            builder.Property(x => x.password).IsRequired();
            builder.Property(x => x.phonenumber).IsRequired();
            builder.HasIndex(x => x.phonenumber).IsUnique();
            builder.Property(x => x.categoryId).IsRequired();
            builder.Property(x => x.degreeId).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
