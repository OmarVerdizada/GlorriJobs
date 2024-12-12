namespace GlorriJobs.Application.dtos.CityDto;

public record GetCityDto
{
    public Guid Id { get; set; }
    public required string Name { get; set; } = null;
}
