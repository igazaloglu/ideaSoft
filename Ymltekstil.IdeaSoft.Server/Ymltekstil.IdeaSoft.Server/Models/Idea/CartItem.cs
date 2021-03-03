using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class CartItem {
    /// <summary>
    /// Sepet kalemi nesnesi kimlik değeri.
    /// </summary>
    /// <value>Sepet kalemi nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Ana ürünün benzersiz rakamsal kimlik değeri.
    /// </summary>
    /// <value>Ana ürünün benzersiz rakamsal kimlik değeri.</value>
    [DataMember(Name="parentProductId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentProductId")]
    public int? ParentProductId { get; set; }

    /// <summary>
    /// Sepetteki kalem adedi.
    /// </summary>
    /// <value>Sepetteki kalem adedi.</value>
    [DataMember(Name="quantity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quantity")]
    public float? Quantity { get; set; }

    /// <summary>
    /// Sepetteki kaleme ait kategorinin benzersiz kimlik değeri.
    /// </summary>
    /// <value>Sepetteki kaleme ait kategorinin benzersiz kimlik değeri.</value>
    [DataMember(Name="categoryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "categoryId")]
    public int? CategoryId { get; set; }

    /// <summary>
    /// Sepet kalemi nesnesinin oluşturulma zamanı.
    /// </summary>
    /// <value>Sepet kalemi nesnesinin oluşturulma zamanı.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Sepet kalemi nesnesinin güncellenme zamanı.
    /// </summary>
    /// <value>Sepet kalemi nesnesinin güncellenme zamanı.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Sepet nesnesi.
    /// </summary>
    /// <value>Sepet nesnesi.</value>
    [DataMember(Name="cart", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cart")]
    public Cart Cart { get; set; }

    /// <summary>
    /// Ürün nesnesi.
    /// </summary>
    /// <value>Ürün nesnesi.</value>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public Product Product { get; set; }

    /// <summary>
    /// Sepet kalemi özelliği barındıran liste.
    /// </summary>
    /// <value>Sepet kalemi özelliği barındıran liste.</value>
    [DataMember(Name="attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attributes")]
    public List<CartItemAttribute> Attributes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CartItem {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ParentProductId: ").Append(ParentProductId).Append("\n");
      sb.Append("  Quantity: ").Append(Quantity).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  Cart: ").Append(Cart).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
