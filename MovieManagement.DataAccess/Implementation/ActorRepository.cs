using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class ActorRepository : GenericRepository<Actor>, IActorRepository
    {
        public MovieManagementDbContext _dbContext { get; }
        public ActorRepository(MovieManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
