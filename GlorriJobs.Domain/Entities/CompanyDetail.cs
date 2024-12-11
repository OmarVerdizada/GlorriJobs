using GlorriJobs.Domain.Entities;

public class CompanyDetail : BaseEntity
{
    public string Content { get; set; }
    public Guid CompanyId { get; set; }
    public Company Company { get; set; }
}
