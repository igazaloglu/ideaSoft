using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class Cart {
    /// <summary>
    /// Sepet nesnesi kimlik değeri.
    /// </summary>
    /// <value>Sepet nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Sepetin son durumunu belirten ilgili nesnenin benzersiz kimlik değeri.
    /// </summary>
    /// <value>Sepetin son durumunu belirten ilgili nesnenin benzersiz kimlik değeri.</value>
    [DataMember(Name="sessionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sessionId")]
    public string SessionId { get; set; }

    /// <summary>
    /// Sepetin kilitli olup olmama durumunu belirten değer. Kilitli sepetler üzerinde işlem yapılamaz.
    /// </summary>
    /// <value>Sepetin kilitli olup olmama durumunu belirten değer. Kilitli sepetler üzerinde işlem yapılamaz.</value>
    [DataMember(Name="locked", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locked")]
    public string Locked { get; set; }

    /// <summary>
    /// Sepet nesnesinin oluşturulma zamanı.
    /// </summary>
    /// <value>Sepet nesnesinin oluşturulma zamanı.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Sepet nesnesinin güncellenme zamanı.
    /// </summary>
    /// <value>Sepet nesnesinin güncellenme zamanı.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Promosyon nesnesi.
    /// </summary>
    /// <value>Promosyon nesnesi.</value>
    [DataMember(Name="chosenPromotion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chosenPromotion")]
    public ShopCampaigns ChosenPromotion { get; set; }

    /// <summary>
    /// Üye nesnesi.
    /// </summary>
    /// <value>Üye nesnesi.</value>
    [DataMember(Name="member", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "member")]
    public Member Member { get; set; }

    /// <summary>
    /// Hediye çeki nesnesi.
    /// </summary>
    /// <value>Hediye çeki nesnesi.</value>
    [DataMember(Name="chosenToken", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chosenToken")]
    public ShopTokens ChosenToken { get; set; }

    /// <summary>
    /// Sepet kalemi nesnelerini barındıran liste.
    /// </summary>
    /// <value>Sepet kalemi nesnelerini barındıran liste.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<CartItem> Items { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Cart {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  SessionId: ").Append(SessionId).Append("\n");
      sb.Append("  Locked: ").Append(Locked).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ChosenPromotion: ").Append(ChosenPromotion).Append("\n");
      sb.Append("  Member: ").Append(Member).Append("\n");
      sb.Append("  ChosenToken: ").Append(ChosenToken).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
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
