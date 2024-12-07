namespace GlorriJobs.Domain.Entities
{
    public class Branch : BaseEntity
    {
        public string Name { get; set; }
        public Guid CityId { get; set; }
        public string Location { get; set; }
        public City City { get; set; }
        public ICollection<Department>? Departments { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        public bool IsMain { get; set; }
    }
}
