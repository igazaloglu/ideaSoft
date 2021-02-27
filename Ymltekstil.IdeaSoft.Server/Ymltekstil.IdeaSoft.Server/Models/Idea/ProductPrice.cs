using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ProductPrice
    {
        /// <summary>
        /// Ürün fiyatı nesnesi kimlik değeri.
        /// </summary>
        /// <value>Ürün fiyatı nesnesi kimlik değeri.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Ürün fiyatı değeri.
        /// </summary>
        /// <value>Ürün fiyatı değeri.</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "value")]
        public float? Value { get; set; }

        /// <summary>
        /// Ürün fiyatı indexi. Fiyat 2, Fiyat 3 gibi.
        /// </summary>
        /// <value>Ürün fiyatı indexi. Fiyat 2, Fiyat 3 gibi.</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        /// <summary>
        /// Ürün nesnesi.
        /// </summary>
        /// <value>Ürün nesnesi.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product")]
        public Product Product { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPrice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
