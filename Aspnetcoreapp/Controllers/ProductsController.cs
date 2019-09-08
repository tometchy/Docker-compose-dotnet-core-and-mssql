using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProductLibrary;

namespace aspnetcoreapp.Controllers
{
    [Route("")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsProvider _provider = new ProductsProvider();

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _provider.GetAll();
        }
    }
}