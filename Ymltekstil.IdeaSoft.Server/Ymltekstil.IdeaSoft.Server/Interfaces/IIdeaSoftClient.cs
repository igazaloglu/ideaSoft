using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ymltekstil.IdeaSoft.Server.Interfaces
{
    public interface IIdeaSoftClient
    {
        void Authorize(string token);
        Task<IEnumerable<Models.Idea.Product>> GetProducts();
    }
}
