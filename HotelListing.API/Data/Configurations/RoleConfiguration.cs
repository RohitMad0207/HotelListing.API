using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    //Id = "0f6b7157-da22-4ea9-90b9-2e7f5b2b5a34",
                    // Id = "one",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                },
                 new IdentityRole
                 {
                    // Id = "4a796476-b50b-4a1a-ba0a-3be88f7b92fb",
                     // Id = "two",
                     Name = "User",
                     NormalizedName = "USER",
                 }
                ) ;  
        }
    }
}
