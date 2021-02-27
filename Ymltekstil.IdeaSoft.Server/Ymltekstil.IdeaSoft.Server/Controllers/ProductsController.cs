using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ymltekstil.IdeaSoft.Server.Base;
using Ymltekstil.IdeaSoft.Server.Interfaces;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ApiController
    {
        private IIdeaSoftClient _ideaSoftClient;


        public ProductsController(IIdeaSoftClient ideaSoftClient)      
        {
            _ideaSoftClient = ideaSoftClient;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var result = await _ideaSoftClient.GetProducts();

            return Ok(result);
        }
    }
}
