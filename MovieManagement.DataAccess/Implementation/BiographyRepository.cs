using MovieManagement.DataAccess.Context;
using MovieManagement.Domain.Entities;
using MovieManagement.Domain.Repository;

namespace MovieManagement.DataAccess.Implementation
{
    public class BiographyRepository : GenericRepository<Biography>, IBiographyRepository
    {
        public MovieManagementDbContext _dbContext { get; }
        public BiographyRepository(MovieManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
