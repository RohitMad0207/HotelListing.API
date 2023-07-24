using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Dto
{
    public abstract class CountryBaseDto
    {
        [Required]
        public string? Name { get; set; }
        public string? ShortName { get; set; }
    }
}
