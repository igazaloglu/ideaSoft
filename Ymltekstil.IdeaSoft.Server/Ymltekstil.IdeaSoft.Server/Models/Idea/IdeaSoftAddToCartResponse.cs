using System.Collections.Generic;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{
    public class IdeaSoftAddToCartResponse
    {
        public IList<CartItem> SucessfullItems { get; set; }
        public IList<CartItem> FailedItems { get; set; }

        public IdeaSoftAddToCartResponse()
        {
            SucessfullItems = new List<CartItem>();
            FailedItems = new List<CartItem>();
        }
    }
}
