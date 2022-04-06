using Practical_16.Web.Contstants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Practical_16.Web.Configration.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "094afa8c-69e3-4103-a542-8aee12940f9a",
                    Name = Roles.Adminstrator,
                    NormalizedName = Roles.Adminstrator.ToUpper()
                },
                new IdentityRole
                {
                    Id = "9f074bba-372c-474e-81a2-92e877a73075",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()
                }
            ); 
        }
    }
}