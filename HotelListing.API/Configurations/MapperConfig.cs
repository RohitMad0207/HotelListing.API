using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Dto;

namespace HotelListing.API.Configurations
{
    public class MapperConfig :Profile
    {
        public MapperConfig() 
        {
            CreateMap<Country , CreateCountryDto>().ReverseMap();
            CreateMap<Country, GetContryDto>().ReverseMap();
            CreateMap<Country, GetContryDetailsDto>().ReverseMap();
            CreateMap<Country ,UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, GetHotelDto>().ReverseMap();
            CreateMap<Hotel, CreateHotelDto>().ReverseMap();
            CreateMap<Hotel, UpdateHotelDto>().ReverseMap();
            
        }
    }
}
