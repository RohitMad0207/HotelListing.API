using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "Sandals Resorts and Spa",
                   Address = "Negril",
                   CountryId = 1,
                   Rating = 5
               },
             new Hotel
             {
                 Id = 2,
                 Name = "Comfort Suites",
                 Address = "George Town",
                 CountryId = 2,
                 Rating = 4.5
             },
             new Hotel
             {
                 Id = 3,
                 Name = "Grand Palldium",
                 Address = "Nassua",
                 CountryId = 3,
                 Rating = 3.8
             }
               );
        }
    }
}
