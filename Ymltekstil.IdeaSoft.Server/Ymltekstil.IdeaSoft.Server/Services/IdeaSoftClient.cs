using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using RestSharp;
using Ymltekstil.IdeaSoft.Server.Base;
using Ymltekstil.IdeaSoft.Server.Interfaces;
using Ymltekstil.IdeaSoft.Server.Models;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Services
{
    public class IdeaSoftClient : WebClientBase, IIdeaSoftClient
    {
        Settings _settngs;

        public IdeaSoftClient(IOptions<Settings> settings) : base("https://ymltekstil.myideasoft.com/api")
        {
            _settngs = settings.Value;
        }

        public async Task<IdeaSoftAddToCartResponse> AddToCart(Cart cart, IEnumerable<CartItem> cartItems)
        {
            var result = new IdeaSoftAddToCartResponse();

            var cartItemRequest = new RestRequest("cart_items", Method.POST);

            foreach (var cartItem in cartItems)
            {
                var createdCartItem = await RestClient.ExecuteGetAsync<CartItem>(cartItemRequest);

                if (!createdCartItem.IsSuccessful)
                {
                    result.FailedItems.Add(cartItem);
                }
                else
                {
                    result.SucessfullItems.Add(cartItem);
                }
            }

            return result;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var productRequest = new RestRequest("products", Method.GET);

             var products = await RestClient.ExecuteGetAsync<IEnumerable<Product>>(productRequest);

            return products.Data;
        }

        public async Task<IdeaSoftTokenResponse> GetToken(string refreshToken)
        {
            var tokenUrl = $"{_settngs.IdeaSoft.TokenUrl}" +
               $"&client_id={_settngs.IdeaSoft.ClientId}" +
               $"&client_secret={_settngs.IdeaSoft.ClientSecret}" +
               $"&refresh_token={refreshToken}";

            var tokenRequest = new RestRequest(tokenUrl, Method.POST);

            var tokenResponse = await RestClient.ExecuteGetAsync<IdeaSoftTokenResponse>(tokenRequest);

            return tokenResponse.Data;
        }
    }
}
