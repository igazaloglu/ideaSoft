using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class MemberGroup {
    /// <summary>
    /// Üye Grubu nesnesi kimlik değeri.
    /// </summary>
    /// <value>Üye Grubu nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Üye Grubu nesnesi için isim değeri.
    /// </summary>
    /// <value>Üye Grubu nesnesi için isim değeri.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Üye Grubunun fiyat indisi. Örnek Fiyat 2.
    /// </summary>
    /// <value>Üye Grubunun fiyat indisi. Örnek Fiyat 2.</value>
    [DataMember(Name="priceIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceIndex")]
    public int? PriceIndex { get; set; }

    /// <summary>
    /// Üye Grubunun izin verilmiş ödeme kanalları.
    /// </summary>
    /// <value>Üye Grubunun izin verilmiş ödeme kanalları.</value>
    [DataMember(Name="allowedPaymentGateways", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedPaymentGateways")]
    public string AllowedPaymentGateways { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MemberGroup {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PriceIndex: ").Append(PriceIndex).Append("\n");
      sb.Append("  AllowedPaymentGateways: ").Append(AllowedPaymentGateways).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
