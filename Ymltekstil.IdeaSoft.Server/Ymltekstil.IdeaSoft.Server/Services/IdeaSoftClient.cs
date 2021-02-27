using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using Ymltekstil.IdeaSoft.Server.Base;
using Ymltekstil.IdeaSoft.Server.Interfaces;
using Ymltekstil.IdeaSoft.Server.Models.Idea;

namespace Ymltekstil.IdeaSoft.Server.Services
{
    public class IdeaSoftClient : WebClientBase, IIdeaSoftClient
    {
        public IdeaSoftClient() : base("https://ymltekstil.myideasoft.com/api")
        {
            Authorize("ZDhmYWI3ZGQ1YjU1MWQ0OTUzNTlhZjIyZWZhNmM5MDI0MWQwMDg4MmE5N2IxOTc4NmIzZDBhZjU1NTU1NDBkZg");
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var productRequest = new RestRequest("products", Method.GET);

            var products = await RestClient.ExecuteGetAsync<IEnumerable<Product>>(productRequest);

            return products.Data;
        }
    }
}
