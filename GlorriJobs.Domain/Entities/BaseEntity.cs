namespace GlorriJobs.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }  // Unikal identifikator
        public DateTime CreatedDate { get; set; }  // Yaradılma tarixi
        public DateTime ModifiedDate { get; set; }  // Dəyişdirilmə tarixi
    }

}
