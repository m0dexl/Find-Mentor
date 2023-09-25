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
    public class FormConfiguration : BaseConfiguration<Form, int>
    {
        public override void Configure(EntityTypeBuilder<Form> builder)
        {
            base.Configure(builder);

<<<<<<< HEAD
           // builder.Property(x => x.Form_Id).IsRequired();
=======
            builder.Property(x => x.Id).IsRequired();
>>>>>>> 2369bb8f74374f008420511d6c190d0acda2ad21

           // builder.HasOne(f => f.Mentor)
           //.WithMany(m => m.Forms)
           //.HasForeignKey(f => f.Id);
        }

    }
}
