using GlorriJobs.Domain.Entities;
using GlorriJobs.Persistence.Contexts;
using GlorriJobs.Persistence.Implements.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace GlorriJobs.Persistence.Implements.Repositories.Implementations;

public class Repository<T> : IRepository<T> where T : BaseEntity
{
    private readonly GlorriJobsDbContext _glorriJobsDbContext;
    private bool ascending;

    public Repository(GlorriJobsDbContext glorriJobsDbContext)
    {
        _glorriJobsDbContext = glorriJobsDbContext;
    }

    public DbSet<T> Table => _glorriJobsDbContext.Set<T>();

    public async Task<T> AddAsync(T entity)
    {
        await _glorriJobsDbContext.AddAsync(entity);
        return entity;
    }
    public T Update(T entity)
    {
        _glorriJobsDbContext.Update(entity);
        return entity;
    }
    public bool Delete(T entity)
    {
        EntityEntry entry = _glorriJobsDbContext.Remove(entity);
        return entry.State == EntityState.Deleted;
    }
    public IQueryable<T> GetAll() => Table.AsNoTracking();
    public IQueryable<T> GetAll(
        Expression<Func<T,bool>> expression = null,
        Expression<Func<T,object>> orderBy = null,
        bool isTracking = false,
        bool ascending = true,
        int skip = 0,
        int take = 10,
        params string[] includes)
    {
        IQueryable<T> query = Table;

        if (includes != null)
        {
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
        }
        if(expression != null)
        {
            query = query.Where(expression);
        }
        if(orderBy != null)
        {
            query = ascending
                ? query.OrderBy(orderBy)
                : query.OrderByDescending(orderBy);
        }

        query = query.Skip(skip).Take(take);

        if (!isTracking)
        {
            query = query.AsNoTracking();
        }

        return query;
    }
    public async Task<T?> GetByIdAsync(Guid id) => await Table.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
    public async Task<T?> GetByFiltered(Expression<Func<T, bool>> expression) => await Table.Where(expression).FirstOrDefaultAsync();
    public async Task SaveChangesAsync() => await _glorriJobsDbContext.SaveChangesAsync();
}
