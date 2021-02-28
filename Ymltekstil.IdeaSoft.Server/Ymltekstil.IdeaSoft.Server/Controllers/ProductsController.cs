using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ymltekstil.IdeaSoft.Server.Base;
using Ymltekstil.IdeaSoft.Server.Interfaces;
using Ymltekstil.IdeaSoft.Server.Models;
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
            HttpContext.Request.Headers.TryGetValue("access_token", out var token);

            if (string.IsNullOrEmpty(token))
            {
                return BadRequest("No access_token key found in headers");
            }

            _ideaSoftClient.Authorize(token);

            var ideaProducts = await _ideaSoftClient.GetProducts();

            var result = ideaProducts
                .Where(p => p.Parent == null)
                .Select(p =>
                {
                    var variants = ideaProducts.Where(product => product.Parent != null && product.Parent.Id == p.Id);

                    return new YmlProduct
                    {
                        MainProduct = p,
                        ProductVariants = variants
                    };
                });

            return Ok(result);
        }
    }
}
