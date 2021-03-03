using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Ymltekstil.IdeaSoft.Server.Base;
using Ymltekstil.IdeaSoft.Server.Interfaces;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ApiController
    {
        public CartController(IIdeaSoftClient ideaSoftClient, IDbSettingsService dbSettingsService) : base(dbSettingsService, ideaSoftClient)
        {
        }

        [HttpPost("api/[controller]/add")]
        public ActionResult<IdeaSoftAddToCartResponse> AddToCart([FromBody] IEnumerable<CartItem> items)
        {
            if(!AuthorizeWithHeader())
            {
                return BadRequest("No access_token key found in headers");
            }

            var result = IdeaSoftClient.AddToCart(null, items);

            return Ok(result);
        }
    }
}
