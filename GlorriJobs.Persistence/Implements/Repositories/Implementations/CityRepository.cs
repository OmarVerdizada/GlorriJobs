using GlorriJobs.Domain.Entities;
using GlorriJobs.Persistence.Contexts;
using GlorriJobs.Persistence.Implements.Repositories.Interfaces;

namespace GlorriJobs.Persistence.Implements.Repositories.Implementations;

public class CityRepository : Repository<City>, ICityRepository
{
    public CityRepository(GlorriJobsDbContext context) : base(context)
    {

    }
}
