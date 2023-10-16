using Core.Utilities;
using System.Text;
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


        builder.HasOne(u => u.Notice)
            .WithOne(n => n.User)
            .HasForeignKey<Notice>(n => n.Mentor_Id);
        
        //using (var hmac = new System.Security.Cryptography.HMACSHA512())
        //{
        //    var passwordSalt = hmac.Key;
        //    var passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("123123123"));

        //    var data = new object[]
        //    {
        //    new {
        //    Id = 0,
        //     Email = "seyit@reateacher.com",
        //    UserName = "seyitadmin",
        //    FirstName = "Seyit",
        //     FullName = "Seyit Camcı",         
        //    PasswordSalt = passwordSalt,
        //     PasswordHash = passwordHash,
        //    UserType = UserType.Admin,
        //     CreatedAt = DateTime.UtcNow.ToTimeZone(),
        //    IsDeleted = false,
        //        }
        //    };
        //    builder.HasData(data);
        //}
    }
}