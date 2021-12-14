using ArchClass.Products.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ArchClass.Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{storename}")]
        public IActionResult GetProductsByStoreName(string storename)
        {
            if (storename == null)
                return BadRequest();

            var productsByStore = _productService.GetProductByStoreName(storename);

            if (productsByStore.Count() <= 0)
                return NotFound();

            return Ok(productsByStore);
        }

    }
}
