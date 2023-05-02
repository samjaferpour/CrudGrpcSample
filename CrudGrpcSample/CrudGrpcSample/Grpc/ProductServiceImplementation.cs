using CrudGrpcSample.Protos;
using CrudGrpcSample.Repositories;
using Grpc.Core;

namespace CrudGrpcSample.Grpc
{
    public class ProductServiceImplementation : ProductService.ProductServiceBase
    {
        private readonly IProductRepository _productRepository;

        public ProductServiceImplementation(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public override Task<AddProductResponse> AddProduct(AddProductRequest request, ServerCallContext context)
        {
            var result = _productRepository.Insert(new Entities.Product { Name = request.Name, Price = request.Price });
            return Task.FromResult(new AddProductResponse { IsSuccess = result });
            //return base.AddProduct(request, context);
        }
    }
}
