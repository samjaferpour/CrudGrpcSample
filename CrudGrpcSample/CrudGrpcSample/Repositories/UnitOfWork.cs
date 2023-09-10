using CrudGrpcSample.Entities;

namespace CrudGrpcSample.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CrudGrpcSampleDbContext _dbContext;

        public UnitOfWork(CrudGrpcSampleDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public void CommitAllChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
