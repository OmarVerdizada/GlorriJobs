using Azure;
using GlorriJobs.Application.dtos.CityDto;
using GlorriJobs.Application.dtos.CityDtos;
using GlorriJobs.Common.Shared;

namespace GlorriJobs.Persistence.Implements.Services.Interfaces;

public interface ICityService
{
    Task<GetCityDto> GetByIdAsync (Guid id);
    Task<Pagination<GetCityDto>> GetAll(int pageNumber=1, int take=10, bool isPaginated=false);
    Task<Pagination<GetCityDto>> SearchByName(string name, int pageNumber = 1, int take = 10, bool isPaginated = false);
    Task<GetCityDto> CreateAsync(CreateCityDto createCityDto);
    Task<GetCityDto> UpdateAsync(Guid id, GetCityDto updateCityDto);
    Task DeleteAsync(Guid id);
}
