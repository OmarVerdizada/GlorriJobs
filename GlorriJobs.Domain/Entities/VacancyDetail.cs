using GlorriJobs.Domain.Entities;

public class VacancyDetail : BaseEntity
{
    public string Content { get; set; }
    public string? Salary { get; set; }

    public Guid VacancyId { get; set; }
    public Vacancy Vacancy { get; set; }
}
