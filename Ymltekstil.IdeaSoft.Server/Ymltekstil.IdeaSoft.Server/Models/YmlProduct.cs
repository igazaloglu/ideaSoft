using System.Collections.Generic;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Models
{
    public class YmlProduct
    {
        public Product MainProduct { get; set; }
        public IEnumerable<Product>  ProductVariants { get; set; }
    }
}
