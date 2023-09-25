using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class FormQuestionConfiguration : IEntityTypeConfiguration<FormQuestion>
    {
        public void Configure(EntityTypeBuilder<FormQuestion> builder)
        {
            builder.HasKey(fq => fq.Id);

            builder.HasOne(fq => fq.Form)
                .WithMany(q => q.QuestionsForForms)
                .HasForeignKey(fq => fq.FormId);

            builder.HasOne(qf => qf.Questions)
                .WithMany(f => f.FormsForQuestions)
                .HasForeignKey(qf => qf.QuestionsId);
                    }
    }
}
