using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
  public class ProductToCategory {
    /// <summary>
    /// Ürün kategori bağı nesnesi kimlik değeri.
    /// </summary>
    /// <value>Ürün kategori bağı nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Ürün kategori bağının sıralama değeri. Özel sıra belirtmek istemiyorsanız 9999 olarak iletebilirsiniz.
    /// </summary>
    /// <value>Ürün kategori bağının sıralama değeri. Özel sıra belirtmek istemiyorsanız 9999 olarak iletebilirsiniz.</value>
    [DataMember(Name="sortOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortOrder")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Ürün nesnesi.
    /// </summary>
    /// <value>Ürün nesnesi.</value>
    [DataMember(Name="product", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "product")]
    public Product Product { get; set; }

    /// <summary>
    /// Kategori nesnesi.
    /// </summary>
    /// <value>Kategori nesnesi.</value>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public Category Category { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ProductToCategory {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Product: ").Append(Product).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
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
