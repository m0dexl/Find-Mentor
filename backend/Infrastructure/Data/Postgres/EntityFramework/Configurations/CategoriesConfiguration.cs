using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class CategoriesConfiguration : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
            //builder.HasKey(x => x.Mentor_Id);
            //builder.Property(x => x.Category_Id).IsRequired();
            //builder.Property(x => x.isValid).IsRequired();

            //builder.HasOne(x => x.Category_Id).WithMany( m => m.)

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Category_Name).IsRequired();
            builder.Property(x => x.Category_Description).IsRequired();
            builder.Property(x => x.Category_Photo).IsRequired();

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
