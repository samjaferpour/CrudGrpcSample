namespace CrudGrpcSample.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        void CommitAllChanges();
    }
}
