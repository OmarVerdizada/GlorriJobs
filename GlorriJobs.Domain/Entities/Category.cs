﻿namespace GlorriJobs.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Vacancy> Vacancies { get; set; }
        public int ExistedVacancy { get; set; }
    }
}