using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Cities")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService) 
        { 
            _productService = productService;
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll(int cityId)
        {
            var productsList = _productService.GetAll();
            return Ok(productsList);
        }

    }
}
