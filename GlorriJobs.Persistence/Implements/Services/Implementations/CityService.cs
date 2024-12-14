using GlorriJobs.Application.dtos.CityDto;
using GlorriJobs.Application.dtos.CityDtos;
using GlorriJobs.Common.Shared;
using GlorriJobs.Persistence.Implements.Repositories.Implementations;
using GlorriJobs.Persistence.Implements.Services.Interfaces;
using GlorriJobs.Persistence.Implements.Services.Implementations;
using GlorriJobs.Persistence.Implements.Repositories.Interfaces;
using Microsoft.Identity.Client;
using GlorriJobs.Common.Exceptions;
using Microsoft.EntityFrameworkCore;

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

    public async Task<Pagination<GetCityDto>> GetAll(int pageNumber = 1, int pageSize = 10, bool isPaginated = false)
    {
        if (pageNumber < 1 || pageSize < 1)
        {
            throw new BadRequestException("Page number and page size should be greater than 0");
        }
    IQueryable<City> query= _cityRepository.GetAll();
        int totalItem=await query.CountAsync();
        if (isPaginated)
        {
            int skip=(pageNumber-1)*pageSize;
            query= query.Skip(skip).Take(pageSize);
        }
        List<GetCityDto> cities = await query.Select(c => new GetCityDto { Id = c.Id, Name = c.Name }).ToListAsync();
        var pagination = new Pagination<GetCityDto>
        {
            Items = cities,
            TotalCount = totalItem,
            TotalPages = (int)Math.Ceiling((double)totalItem / pageSize),
            PageIndex = pageNumber,
            PageSize = isPaginated ? pageSize : totalItem,
        };
        return pagination;
    }

    public Task<GetCityDto> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Pagination<GetCityDto>> SearchByName(string name, int pageNumber = 1, int pageSize = 10, bool isPaginated = false)
    {
        if (pageNumber < 1 || pageSize < 1)
        {
            throw new BadRequestException("Page number and page size should be greater than 0");
        }
        IQueryable<City> query = _cityRepository.GetAll(expression: c => c.Name.ToLower().Contains(name.ToLower()));
        int totalItem = query.Count();
        if (isPaginated)
        {
            int skip = (pageNumber - 1) * pageSize;
            query = query.Skip(skip).Take(pageSize);
        }
        List<GetCityDto> cities = await query.Select(c => new GetCityDto { Id = c.Id, Name = c.Name }).ToListAsync();
        var pagination = new Pagination<GetCityDto>
        {
            Items = cities,
            TotalCount = totalItem,
            TotalPages = (int)Math.Ceiling((double)totalItem / pageSize),
            PageIndex = pageNumber,
            PageSize = isPaginated ? pageSize : totalItem,
        };
        return pagination;
    }

    public Task<GetCityDto> UpdateAsync(Guid id, GetCityDto updateCityDto)
    {
        throw new NotImplementedException();
    }
}
