using AutoMapper;
using DocumentFormat.OpenXml.Bibliography;
using GlorriJobs.Application.dtos.CityDto;
using GlorriJobs.Application.dtos.CityDtos;

namespace GlorriJobs.Application.Profiles;
public class CityProfile:Profile
{
    public CityProfile()
    {
        CreateMap<City,GetCityDto>().ReverseMap();
        CreateMap<City,UpdateCityDto>().ReverseMap();
        CreateMap<City,CreateCityDto>().ReverseMap();
    }
}
