using Microsoft.EntityFrameworkCore;
using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public ActorRepository(MovieManagementDbContext dbContext) : base(dbContext)
        {

        }

        public IEnumerable<Actor> GetActorsWithMovies()
        {
            return _dbContext.Actors.Include(a => a.Movies).ToList();
        }
    }
}
