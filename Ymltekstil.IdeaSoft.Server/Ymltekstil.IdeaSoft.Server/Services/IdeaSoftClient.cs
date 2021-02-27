﻿using System.Collections.Generic;
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
            Authorize("OWFmMmZiOGY5MjdiZTQ0N2JhYWZiODk0MDNiODU1MDYxOTZmMjEzMzI5MTFmYWE1MjkzYTliM2QxM2M0OGVkNg");
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var productRequest = new RestRequest("products", Method.GET);

            var products = await RestClient.ExecuteGetAsync<IEnumerable<Product>>(productRequest);

            return products.Data;
        }
    }
}