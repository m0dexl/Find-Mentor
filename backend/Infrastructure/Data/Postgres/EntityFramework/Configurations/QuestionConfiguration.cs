using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class QuestionConfiguration :BaseConfiguration<Questions, int>
    {
        public override void Configure(EntityTypeBuilder<Questions> builder)
        {
            base.Configure(builder);



            /*builder.HasKey(fq => new { fq.Id, fq.Question_Id });*/ //form_id gelmiyor

            //builder.HasOne(fq => fq.Form)
            //    .WithMany(f => f.QuestionsV)
            //    .HasForeignKey(fq => fq.Id); //form_id gelmiyor

            //sadas
            //builder.HasOne(x => x.Form).WithOne(x => x.Questions).HasForeignKey<Questions>(x => x.Question_Id);
            builder.HasKey(fq => fq.Id );

            builder.HasMany(s => s.FormsForQuestions)
               .WithOne(sc => sc.Questions)
               .HasForeignKey(sc => sc.QuestionsId);

            //builder.HasOne(f => f.Form)
            //    .WithMany(f => f.QuestionsLıst)
            //    .HasForeignKey(fq => fq.Form_Id); 


            //builder.HasOne(x => x.Form).WithOne(x => x.Questions).HasForeignKey<Questions>(x => x.Id);


        }
        
    }

}

