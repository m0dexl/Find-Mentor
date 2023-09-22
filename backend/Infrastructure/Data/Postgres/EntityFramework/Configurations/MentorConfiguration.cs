using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class MentorConfiguration: BaseConfiguration<Mentor, int>
    {
        public override void Configure(EntityTypeBuilder<Mentor> builder)
        {
            base.Configure(builder); // Base configuration from the abstract class

            builder.HasKey(x => x.Mentor_Id);

            builder.HasOne(x=>x.User).WithOne(x => x.Mentor).HasForeignKey<Mentor>(x => x.User_Id);


            //builder.HasKey(x => x.Mentor_Id);
            //builder.Property(x => x.Category_Id).IsRequired();
            //builder.Property(x => x.isValid).IsRequired();

            //builder.HasMany(c => c.Categories)
            //    .WithOne(c => c.Mentor)
            //    .HasForeignKey(c => c.Mentor_id);



            //builder.HasKey(x => x.mentorId);
            //builder.Property(x => x.mail).IsRequired();
            //builder.HasIndex(x => x.mail).IsUnique();
            //builder.Property(x => x.name).IsRequired();
            //builder.HasIndex(x => x.name).IsUnique();
            //builder.Property(x => x.lastname).IsRequired();
            //builder.Property(x => x.password).IsRequired();
            //builder.Property(x => x.phonenumber).IsRequired();
            //builder.HasIndex(x => x.phonenumber).IsUnique();
            //builder.Property(x => x.categoryId).IsRequired();
            //builder.Property(x => x.degreeId).IsRequired();
            //builder.Property(x => x.IsActive).IsRequired();
        }
    }
}
