﻿namespace GlorriJobs.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Branch> Branches { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
    }
}
