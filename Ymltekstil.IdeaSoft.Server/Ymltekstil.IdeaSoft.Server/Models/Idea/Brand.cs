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
    public class Brand
    {
        /// <summary>
        /// Marka nesnesi kimlik değeri.
        /// </summary>
        /// <value>Marka nesnesi kimlik değeri.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Marka nesnesi için isim değeri.
        /// </summary>
        /// <value>Marka nesnesi için isim değeri.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Slug değeri ilgili nesnenin Url değeridir.
        /// </summary>
        /// <value>Slug değeri ilgili nesnenin Url değeridir.</value>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Marka nesnesi için sıralama değeri.
        /// </summary>
        /// <value>Marka nesnesi için sıralama değeri.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Marka nesnesinin aktiflik durumunu belirten değer.<div class='idea_choice_list'><code>1</code> : Aktif.<br><code>0</code> : Pasif.<br></div>
        /// </summary>
        /// <value>Marka nesnesinin aktiflik durumunu belirten değer.<div class='idea_choice_list'><code>1</code> : Aktif.<br><code>0</code> : Pasif.<br></div></value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Markanın tedarikçisi.
        /// </summary>
        /// <value>Markanın tedarikçisi.</value>
        [DataMember(Name = "distributor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "distributor")]
        public string Distributor { get; set; }

        /// <summary>
        /// Marka nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .JPG, .PNG, .GIF
        /// </summary>
        /// <value>Marka nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .JPG, .PNG, .GIF</value>
        [DataMember(Name = "imageFile", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "imageFile")]
        public string ImageFile { get; set; }

        /// <summary>
        /// Marka nesnesinin üst içeriği. Admin paneli üzerinden düzenlenebilir.
        /// </summary>
        /// <value>Marka nesnesinin üst içeriği. Admin paneli üzerinden düzenlenebilir.</value>
        [DataMember(Name = "showcaseContent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "showcaseContent")]
        public string ShowcaseContent { get; set; }

        /// <summary>
        /// Marka nesnesi üst içerik metninin gösterim durumu.
        /// </summary>
        /// <value>Marka nesnesi üst içerik metninin gösterim durumu.</value>
        [DataMember(Name = "displayShowcaseContent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "displayShowcaseContent")]
        public string DisplayShowcaseContent { get; set; }

        /// <summary>
        /// Arama motorları tarafından tespit edilebilecek anahtar kelimeler.
        /// </summary>
        /// <value>Arama motorları tarafından tespit edilebilecek anahtar kelimeler.</value>
        [DataMember(Name = "metaKeywords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metaKeywords")]
        public string MetaKeywords { get; set; }

        /// <summary>
        /// Arama motorları tarafından tespit edilebilecek açıklama yazısı.
        /// </summary>
        /// <value>Arama motorları tarafından tespit edilebilecek açıklama yazısı.</value>
        [DataMember(Name = "metaDescription", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "metaDescription")]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Marka nesnesinin etiket başlığı.
        /// </summary>
        /// <value>Marka nesnesinin etiket başlığı.</value>
        [DataMember(Name = "pageTitle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageTitle")]
        public string PageTitle { get; set; }

        /// <summary>
        /// Marka nesnesinin görselinin base64 formatına çevrilmiş resim kodu. PUT ve POST istekleri gerçekleştirlirken başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir.
        /// </summary>
        /// <value>Marka nesnesinin görselinin base64 formatına çevrilmiş resim kodu. PUT ve POST istekleri gerçekleştirlirken başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir.</value>
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachment")]
        public string Attachment { get; set; }

        /// <summary>
        /// Marka nesnesinin oluşturulma zamanı.
        /// </summary>
        /// <value>Marka nesnesinin oluşturulma zamanı.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Marka nesnesinin güncellenme zamanı.
        /// </summary>
        /// <value>Marka nesnesinin güncellenme zamanı.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Brand {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Distributor: ").Append(Distributor).Append("\n");
            sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  ShowcaseContent: ").Append(ShowcaseContent).Append("\n");
            sb.Append("  DisplayShowcaseContent: ").Append(DisplayShowcaseContent).Append("\n");
            sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}
