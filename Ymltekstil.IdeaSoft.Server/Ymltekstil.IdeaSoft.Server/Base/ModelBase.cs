using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Base
{
    public abstract class ModelBase
    {
        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}
