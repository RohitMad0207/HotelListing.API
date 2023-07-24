namespace HotelListing.API.Dto
{
    public class GetContryDetailsDto : CountryBaseDto
    {
        public int Id { get; set; }
        public List<GetHotelDto> Hotels { get; set; }
    }
}
