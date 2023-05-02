using CrudGrpcSample.Entities;

namespace CrudGrpcSample.Repositories
{
    public interface IProductRepository
    {
        List<Product> SelectAll();
        Product SelectById(int id);
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(int id);
    }
}
