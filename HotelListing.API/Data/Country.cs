using HotelListing.API.Dto;

namespace HotelListing.API.Data
{
    public class Country : CountryBaseDto
    {
        public int Id { get; set; }
        public virtual IList<Hotel>? Hotels { get; set; }
    }
}