﻿using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class MentorFormConfiguration : IEntityTypeConfiguration<MentorForm>
    {
        public void Configure(EntityTypeBuilder<MentorForm> builder)
        {
            // composite primary key
            builder.HasKey(mc => new { mc.MentorId, mc.FormId });

            // yeni sildim


            //coktan coka iliski
            builder.HasOne(mf => mf.Mentor)
                .WithMany(f => f.Formlar)
                .HasForeignKey(m => m.MentorId);

            builder.HasOne(mf => mf.Form)
                .WithMany(m => m.Mentorler)
                .HasForeignKey(m => m.FormId);
        }
    }
}
