using CrudGrpcSample.Entities;
using CrudGrpcSample.Protos;
using CrudGrpcSample.Repositories;
using Grpc.Core;

namespace CrudGrpcSample.Grpc
{
    public class GrpcProductService : ProductService.ProductServiceBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public GrpcProductService(IProductRepository productRepository,
                                  IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public override async Task<AddProductResponse> AddProduct(AddProductRequest request, ServerCallContext context)
        { 
            var response = _productRepository.Insert(new Product
            {
                Name = request.Name,
                Price = request.Price
            });

            _unitOfWork.CommitAllChanges();

            return new AddProductResponse
            {
                IsSuccess = response
            };
        }
    }
}
