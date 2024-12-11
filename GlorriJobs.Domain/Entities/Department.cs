namespace GlorriJobs.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public Guid BranchId { get; set; }
        public Branch Branch { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
