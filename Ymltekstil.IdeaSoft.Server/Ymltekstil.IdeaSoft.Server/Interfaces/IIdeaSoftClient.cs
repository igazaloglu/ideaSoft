using System.Collections.Generic;
using System.Threading.Tasks;
using Ymltekstil.IdeaSoft.Server.Models;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Interfaces
{
    public interface IIdeaSoftClient
    {
        Task<IdeaSoftTokenResponse> GetToken(string refreshToken);
        void Authorize(string token);
        Task<IEnumerable<Models.Idea.Product>> GetProducts();

        Task<IdeaSoftAddToCartResponse> AddToCart(Cart cart,IEnumerable<CartItem> cartItems);
    }
}
