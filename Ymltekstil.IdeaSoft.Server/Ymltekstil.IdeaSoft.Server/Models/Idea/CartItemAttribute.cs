using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class CartItemAttribute {
    /// <summary>
    /// Sepet kalemi özelliği nesnesi kimlik değeri.
    /// </summary>
    /// <value>Sepet kalemi özelliği nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Sepet kalemi özelliği nesnesinin isim değeri. Örneğin, sepet kalemi kalem ise bu değer renk olabilir.
    /// </summary>
    /// <value>Sepet kalemi özelliği nesnesinin isim değeri. Örneğin, sepet kalemi kalem ise bu değer renk olabilir.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Sepet kalemi özelliği nesnesinin değeri. Örneğin, sepet kalemi kalem, isim değeri renk ise bu değer kırmızı olabilir.
    /// </summary>
    /// <value>Sepet kalemi özelliği nesnesinin değeri. Örneğin, sepet kalemi kalem, isim değeri renk ise bu değer kırmızı olabilir.</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// Sepet kalemi özelliği nesnesinin oluşturulma zamanı.
    /// </summary>
    /// <value>Sepet kalemi özelliği nesnesinin oluşturulma zamanı.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Sepet kalemi nesnesi.
    /// </summary>
    /// <value>Sepet kalemi nesnesi.</value>
    [DataMember(Name="cartItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cartItem")]
    public CartItem CartItem { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CartItemAttribute {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  CartItem: ").Append(CartItem).Append("\n");
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
