using GlorriJobs.Domain.Entities;
using GlorriJobs.Domain.Enums;

public class Vacancy : BaseEntity
{
    public Guid? ParentVacancyId { get; set; }
    public Vacancy ParentVacancy { get; set; }
    public ICollection<Vacancy> SubVacancies { get; set; }

    public string Title { get; set; }
    public Guid VacancyTypeId { get; set; } // Self-referencing FK
    public Vacancy VacancyType { get; set; }

    public Guid CategoryId { get; set; }
    public Category Category { get; set; }

    public Guid CompanyId { get; set; }
    public Company Company { get; set; }

    public Guid BranchId { get; set; }
    public Branch Branch { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; }

    public Guid CityId { get; set; }
    public City City { get; set; }

    public bool IsSalaryVisible { get; set; }
    public bool IsRemote { get; set; }
    public JobLevel JobLevel { get; set; }
    public int ViewCount { get; set; }
}
