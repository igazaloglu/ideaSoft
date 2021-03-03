using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class Location {
    /// <summary>
    /// Şehir nesnesi kimlik değeri.
    /// </summary>
    /// <value>Şehir nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Şehir nesnesi için isim değeri.
    /// </summary>
    /// <value>Şehir nesnesi için isim değeri.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Şehir nesnesinin aktiflik durumunu belirten değer.
    /// </summary>
    /// <value>Şehir nesnesinin aktiflik durumunu belirten değer.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Şehir nesnesinin öntanımlı olup olmadığını belirtir.<div class='idea_choice_list'><code>1</code> : Öntanımlı şehir.<br><code>0</code> : Yeni eklenmiş şehir.<br></div>
    /// </summary>
    /// <value>Şehir nesnesinin öntanımlı olup olmadığını belirtir.<div class='idea_choice_list'><code>1</code> : Öntanımlı şehir.<br><code>0</code> : Yeni eklenmiş şehir.<br></div></value>
    [DataMember(Name="predefined", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "predefined")]
    public string Predefined { get; set; }

    /// <summary>
    /// Ülke nesnesi.
    /// </summary>
    /// <value>Ülke nesnesi.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public Country Country { get; set; }

    /// <summary>
    /// Bölge nesnesi.
    /// </summary>
    /// <value>Bölge nesnesi.</value>
    [DataMember(Name="region", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "region")]
    public Region Region { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Location {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Predefined: ").Append(Predefined).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Region: ").Append(Region).Append("\n");
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
