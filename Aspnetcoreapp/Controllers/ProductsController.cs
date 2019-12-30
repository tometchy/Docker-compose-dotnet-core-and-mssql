using System;
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
            try
            {
                return _provider.GetAll();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception during providing products, maybe DB is not fully initialized yet? " +
                                  $"Try again in a few minutes and if it doesn't help, check your docker-compose configuration.\n{e}");
                
                return new Product[0];
            }
        }
    }
}