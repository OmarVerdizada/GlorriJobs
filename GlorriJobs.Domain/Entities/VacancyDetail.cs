using GlorriJobs.Domain.Entities;

public class VacancyDetail : BaseEntity
{
    public Guid? RelatedVacancyId { get; set; }
    public Vacancy RelatedVacancy { get; set; }
    public Guid VacancyId { get; set; }
    public Vacancy Vacancy { get; set; }
    public string Content { get; set; }
    public DateTime ExpireDate { get; set; }
    public string? Salary { get; set; }
}
