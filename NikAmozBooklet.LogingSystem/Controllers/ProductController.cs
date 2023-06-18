using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NikAmozBooklet.LogingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> logger;
        private readonly ILogger logger2;



        public ProductController(ILogger<ProductController> logger,ILoggerFactory factory)
        {
            this.logger = logger;
            this.logger2 = factory.CreateLogger("Manual Category");
        }

        [HttpGet("Product")]
        public IActionResult GetProduct(int id)
        {
            logger.LogInformation("This Admin Get Product Information By this ({ID})", id);
            logger2.LogInformation("This Admin Get Product Information By this ({ID})", id);
            return Ok(new { Id = id, Name = $"Product {id}" });
        }
    }
}
