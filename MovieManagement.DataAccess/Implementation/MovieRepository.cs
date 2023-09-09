using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class MovieRepository : GenericRepository<Movie>, IMovieRepository
    {
        public MovieManagementDbContext _dbContext { get; }
        public MovieRepository(MovieManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
