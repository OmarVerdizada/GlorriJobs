using Microsoft.EntityFrameworkCore;
using GlorriJobs.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;
using GlorriJobs.Domain.Entities;

namespace GlorriJobs.Persistence.Contexts
{
    public class GlorriJobsDbContext : DbContext
    {
        public GlorriJobsDbContext(DbContextOptions<GlorriJobsDbContext> options)
        : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Biography> Biographies { get; set; }
        public DbSet<Industry> Industries { get; set; }
        public DbSet<VacancyDetail> VacancyDetails { get; set; }
        public DbSet<CompanyDetail> CompanyDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the one-to-one relationship between Company and CompanyDetail
            modelBuilder.Entity<Company>()
                .HasOne(c => c.CompanyDetail)
                .WithOne(cd => cd.Company)
                .HasForeignKey<CompanyDetail>(cd => cd.CompanyId);

            // Configure the other relationships with "NO ACTION" for cascading
            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.VacancyDetail)
                .WithOne(vd => vd.Vacancy)
                .HasForeignKey<VacancyDetail>(vd => vd.VacancyId);

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Category)
                .WithMany(c => c.Vacancies)
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Company)
                .WithMany(c => c.Vacancies)
                .HasForeignKey(v => v.CompanyId)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Branch)
                .WithMany(b => b.Vacancies)
                .HasForeignKey(v => v.BranchId)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Department)
                .WithMany(d => d.Vacancies)
                .HasForeignKey(v => v.DepartmentId)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.City)
                .WithMany(c => c.Vacancies)
                .HasForeignKey(v => v.CityId)
                .OnDelete(DeleteBehavior.NoAction);  // Prevent cascading delete
        }



    }
}
