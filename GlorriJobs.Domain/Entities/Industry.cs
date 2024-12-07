namespace GlorriJobs.Domain.Entities
{
    public class Industry : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Company> Companies { get; set; }
    }
}
