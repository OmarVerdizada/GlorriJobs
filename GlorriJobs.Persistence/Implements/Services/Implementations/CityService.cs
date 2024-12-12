using GlorriJobs.Application.dtos.CityDto;
using GlorriJobs.Application.dtos.CityDtos;
using GlorriJobs.Common.Shared;
using GlorriJobs.Persistence.Implements.Repositories.Implementations;
using GlorriJobs.Persistence.Implements.Services.Interfaces;
using GlorriJobs.Persistence.Implements.Services.Implementations;
using GlorriJobs.Persistence.Implements.Repositories.Interfaces;

namespace GlorriJobs.Persistence.Implements.Services.Implementations;

public class CityService : ICityService
{
    private ICityRepository _cityRepository {  get; set; }  
    public CityService(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }
    public Task<GetCityDto> CreateAsync(CreateCityDto createCityDto)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(Guid id)
    {
        var city = await _cityRepository.GetByIdAsync(id);
        if (city is null)
        {

        }
    }

    public Task<Pagination<GetCityDto>> GetAll(int pageNumber = 1, int take = 10, bool isPaginated = false)
    {
        throw new NotImplementedException();
    }

    public Task<GetCityDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Pagination<GetCityDto>> SearchByName(string name, int pageNumber = 1, int take = 10, bool isPaginated = false)
    {
        throw new NotImplementedException();
    }

    public Task<GetCityDto> UpdateAsync(Guid id, GetCityDto updateCityDto)
    {
        throw new NotImplementedException();
    }
}
