using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Data;

namespace ProductCatalog.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]

        public object Get()
        {
            return new { version = "Product Catalog v0.0.1" };
        }

    }

}