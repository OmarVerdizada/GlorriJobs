using GlorriJobs.Domain.Entities;
using GlorriJobs.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace GlorriJobs.Persistence.Implements.Repositories.Interfaces;

public interface IRepository<T> where T : BaseEntity
{
    DbSet<T> Table { get; }

    Task<T> AddAsync(T entity);
    T Update(T entity);
    bool Delete(T entity);
    IQueryable<T> GetAll();
    IQueryable<T> GetAll(
        Expression<Func<T, bool>> expression = null,
        Expression<Func<T, object>> orderBy = null,
        bool isTracking = false,
        bool ascending = true,
        params string[] includes);
    Task<T?> GetByIdAsync(Guid id);
    Task<T?> GetByFiltered(Expression<Func<T, bool>> expression);
    Task SaveChangesAsync();
}
