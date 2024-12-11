namespace GlorriJobs.Domain.Entities
{
    public class Biography : BaseEntity
    {
        public string Icon { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
