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
        public ProductsController(IIdeaSoftClient ideaSoftClient, IDbSettingsService dbSettingsService) : base(dbSettingsService, ideaSoftClient)
        {
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<YmlProduct>>> GetProducts()
        {
            await Authorize();

            var ideaProducts = await IdeaSoftClient.GetProducts();

            var result = ideaProducts
                .Where(p => p.Parent == null)
                .Select(p =>
                {
                    var variants = ideaProducts.Where(product => product.Parent != null && product.Parent.Id == p.Id);

                    var colorsAndSizes = variants.Select(v => v.Name).Select(x => x.Split("-"));
                    var colors = colorsAndSizes.Select(cs => cs.First().Trim()).Distinct();
                    var sizes = colorsAndSizes.Select(cs => cs.Last().Trim()).Distinct();

                    var imageMap = new Dictionary<string, Dictionary<string, IEnumerable<ProductImage>>>();

                    foreach(var color in colors)
                    {
                        foreach(var size in sizes)
                        {
                            var images = variants.Where(v => v.Name.Trim() == $"{color}-{size}").SelectMany(v => v.Images).ToList();
                            var sizeImagePairs = new Dictionary<string, IEnumerable<ProductImage>>();

                            sizeImagePairs.Add(size, images);

                            if(images.Count > 0)
                            {
                                if (imageMap.ContainsKey(color))
                                {
                                    imageMap[color].Add(size, images);
                                }
                                else
                                {
                                    imageMap.Add(color, sizeImagePairs);
                                }
                            }
                        }
                    }

                    return new YmlProduct
                    {
                        MainProduct = p,
                        ProductVariants = variants,
                        Colors = colors.ToList(),
                        Sizes = sizes.ToList(),
                        ImageMap = imageMap
                    };
                });

            return Ok(result);
        }
    }
}
