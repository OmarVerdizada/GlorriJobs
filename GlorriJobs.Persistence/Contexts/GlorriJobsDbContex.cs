using Microsoft.EntityFrameworkCore;
using GlorriJobs.Domain.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;
using GlorriJobs.Domain.Entities;

namespace GlorriJobs.Persistence.Contexts
{
    public class GlorriJobsDbContext : DbContext
    {

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=GlorriJobsDb;User Id=sa;Password=P@ssw0rd;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships for Vacancy entity
            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.VacancyType) // Self-referencing foreign key
                .WithMany()
                .HasForeignKey(v => v.VacancyTypeId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Category)
                .WithMany()
                .HasForeignKey(v => v.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.City)
                .WithMany()
                .HasForeignKey(v => v.CityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Company)
                .WithMany(c => c.Vacancies)
                .HasForeignKey(v => v.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Branch)
                .WithMany()
                .HasForeignKey(v => v.BranchId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.Department)
                .WithMany()
                .HasForeignKey(v => v.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Vacancy>()
                .HasOne(v => v.ParentVacancy) // Self-referencing relationship
                .WithMany(v => v.SubVacancies)
                .HasForeignKey(v => v.ParentVacancyId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure relationships for VacancyDetail entity
            modelBuilder.Entity<VacancyDetail>()
                .HasOne(vd => vd.Vacancy)
                .WithMany()
                .HasForeignKey(vd => vd.VacancyId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<VacancyDetail>()
                .HasOne(vd => vd.RelatedVacancy)
                .WithMany()
                .HasForeignKey("RelatedVacancyId")
                .OnDelete(DeleteBehavior.Restrict);

            // Configure relationships for Company and CompanyDetail
            modelBuilder.Entity<Company>()
                .HasOne(c => c.CompanyDetail)
                .WithOne(cd => cd.Company)
                .HasForeignKey<CompanyDetail>(cd => cd.CompanyId)
                .OnDelete(DeleteBehavior.Cascade);
        }



    }
}
