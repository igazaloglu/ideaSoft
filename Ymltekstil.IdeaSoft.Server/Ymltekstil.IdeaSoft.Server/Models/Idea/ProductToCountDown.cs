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
    public class ProductToCountDown
    {
        /// <summary>
        /// Ürün geri sayım bağı nesnesi kimlik değeri.
        /// </summary>
        /// <value>Ürün geri sayım bağı nesnesi kimlik değeri.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Geri sayımın başlangıç tarihi.
        /// </summary>
        /// <value>Geri sayımın başlangıç tarihi.</value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "startDate")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Geri sayımın bitiş tarihi.
        /// </summary>
        /// <value>Geri sayımın bitiş tarihi.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "endDate")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Geri sayımın ürün için geçersiz olma tarihi.
        /// </summary>
        /// <value>Geri sayımın ürün için geçersiz olma tarihi.</value>
        [DataMember(Name = "expireDate", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "expireDate")]
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// Geri sayımın aktiflik durumu bilgisini belirtir.<div class='idea_choice_list'><code>1</code> : Aktif.<br><code>0</code> : Pasif.<br></div>
        /// </summary>
        /// <value>Geri sayımın aktiflik durumu bilgisini belirtir.<div class='idea_choice_list'><code>1</code> : Aktif.<br><code>0</code> : Pasif.<br></div></value>
        [DataMember(Name = "useCountDown", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "useCountDown")]
        public string UseCountDown { get; set; }

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
            sb.Append("class ProductToCountDown {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ExpireDate: ").Append(ExpireDate).Append("\n");
            sb.Append("  UseCountDown: ").Append(UseCountDown).Append("\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
