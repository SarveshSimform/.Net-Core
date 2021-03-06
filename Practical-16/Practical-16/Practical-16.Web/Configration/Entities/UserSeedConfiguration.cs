using Practical_16.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Practical_16.Web.Configration.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            var haser = new PasswordHasher<User>();
            builder.HasData(
                new User
                {
                    Id = "5b2546a3-3e7a-454e-ac18-52d4cae97b2f",
                    Email = "admin23@gmail.com",
                    NormalizedEmail = "ADMIN23@GMAIL.COM",
                    UserName = "admin23@gmail.com",
                    NormalizedUserName = "ADMIN23@GMAIL.COM",
                    FirstName = "Dhruvin",
                    LastName = "Jariwala",
                    PasswordHash = haser.HashPassword(null, "Jdhruvin@5042"),
                    EmailConfirmed = true

                },
                 new User
                 {
                     Id = "4b2546a3-3e7a-424e-ac18-52d4cae97b2f",
                     Email = "user@gmail.com",
                     NormalizedEmail = "USER@GMAIL.COM",
                     NormalizedUserName = "USER@GMAIL.COM",
                     UserName = "user@gmail.com",
                     FirstName = "system",
                     LastName = "user",
                     PasswordHash = haser.HashPassword(null, "Jdhruvin@5042"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}