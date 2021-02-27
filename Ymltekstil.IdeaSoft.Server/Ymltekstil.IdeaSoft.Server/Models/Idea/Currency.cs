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
    public class Currency
    {
        /// <summary>
        /// Kur nesnesi kimlik değeri.
        /// </summary>
        /// <value>Kur nesnesi kimlik değeri.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Kur etiketi.
        /// </summary>
        /// <value>Kur etiketi.</value>
        [DataMember(Name = "label", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

        /// <summary>
        /// Kurun alış fiyatı.
        /// </summary>
        /// <value>Kurun alış fiyatı.</value>
        [DataMember(Name = "buyingPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "buyingPrice")]
        public float? BuyingPrice { get; set; }

        /// <summary>
        /// Kurun satış fiyatı.
        /// </summary>
        /// <value>Kurun satış fiyatı.</value>
        [DataMember(Name = "sellingPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sellingPrice")]
        public float? SellingPrice { get; set; }

        /// <summary>
        /// Kurun kısaltması.
        /// </summary>
        /// <value>Kurun kısaltması.</value>
        [DataMember(Name = "abbr", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "abbr")]
        public string Abbr { get; set; }

        /// <summary>
        /// Kur nesnesinin güncellenme zamanı.
        /// </summary>
        /// <value>Kur nesnesinin güncellenme zamanı.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Kur nesnesinin aktiflik durumunu belirten değer.<div class='idea_choice_list'><code>1</code> : Aktif.<br><code>0</code> : Pasif.<br></div>
        /// </summary>
        /// <value>Kur nesnesinin aktiflik durumunu belirten değer.<div class='idea_choice_list'><code>1</code> : Aktif.<br><code>0</code> : Pasif.<br></div></value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Kurun birincil kur olup olmadığı bilgisini belirtir.<div class='idea_choice_list'><code>1</code> : Birincil kur.<br><code>0</code> : Birincil kur değil.<br></div>
        /// </summary>
        /// <value>Kurun birincil kur olup olmadığı bilgisini belirtir.<div class='idea_choice_list'><code>1</code> : Birincil kur.<br><code>0</code> : Birincil kur değil.<br></div></value>
        [DataMember(Name = "isPrimary", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isPrimary")]
        public string IsPrimary { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Currency {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  BuyingPrice: ").Append(BuyingPrice).Append("\n");
            sb.Append("  SellingPrice: ").Append(SellingPrice).Append("\n");
            sb.Append("  Abbr: ").Append(Abbr).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

    }
}
