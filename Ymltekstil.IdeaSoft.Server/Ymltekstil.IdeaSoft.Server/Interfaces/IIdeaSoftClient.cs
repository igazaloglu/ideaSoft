using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ymltekstil.IdeaSoft.Server.Interfaces
{
    public interface IIdeaSoftClient
    {
        Task<IEnumerable<Models.Idea.Product>> GetProducts();
    }
}
