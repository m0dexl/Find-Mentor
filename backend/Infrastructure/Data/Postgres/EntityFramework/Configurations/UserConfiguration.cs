using Infrastructure.Data.Postgres.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Postgres.EntityFramework.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).IsRequired();
        builder.HasIndex(x => x.Email).IsUnique();
        builder.Property(x => x.UserName).IsRequired();
        builder.HasIndex(x => x.UserName).IsUnique();
        builder.Property(x => x.FullName).IsRequired();
        builder.Property(x => x.PasswordHash).IsRequired();
        builder.Property(x => x.PasswordSalt).IsRequired();
        builder.Property(x => x.CreatedAt).IsRequired();
        builder.Property(x => x.IsDeleted).IsRequired();

        //builder.HasOne(x => x.Mentor).WithOne(x => x.User).HasForeignKey<User>(x => x.Mentor_Id);
        // yeni cikardim 24/09 cunku kalitimla cozdum birebir iliskiye gerek kalmadi

        builder.HasOne(x => x.Mentor)
                .WithOne(x => x.User)
                .HasForeignKey<User>(x => x.Id);

    }
}