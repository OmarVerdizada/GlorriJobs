namespace GlorriJobs.Application.dtos.CityDtos;
public record UpdateCityDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; }
}
