using CrudGrpcSample.Protos;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Endpoint.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> AddNew(AddProductRequest request)
        { 
        
            var channel = GrpcChannel.ForAddress("https://localhost:7196/");

            var productClient = new ProductService.ProductServiceClient(channel);

            var result = productClient.AddProduct(request);
            return Ok(result);
        }
    }
}
