namespace GlorriJobs.Application.dtos.IdentityDto;
public record LoginDto
{
    public required string Username { get; set; }
    public required string Password { get; set; }

}
