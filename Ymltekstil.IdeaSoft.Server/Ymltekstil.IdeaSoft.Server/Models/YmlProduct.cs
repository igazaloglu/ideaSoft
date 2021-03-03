using System.Collections.Generic;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Models
{
    public class YmlProduct
    {
        public Product MainProduct { get; set; }
        public IEnumerable<Product>  ProductVariants { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }

        public new Dictionary<string, Dictionary<string, IEnumerable<ProductImage>>> ImageMap { get; set; }
    }
}
