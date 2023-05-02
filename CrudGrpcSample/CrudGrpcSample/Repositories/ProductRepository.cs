using CrudGrpcSample.Entities;

namespace CrudGrpcSample.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly CrudGrpcSampleDbContext _context;

        public ProductRepository(CrudGrpcSampleDbContext context) 
        {
            this._context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                _context.Products.Remove(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Insert(Product product)
        {
            try
            {
                _context.Products.Add(product);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Product> SelectAll()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Product SelectById(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public bool Update(Product product)
        {
            try
            {
                _context.Products.Update(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
