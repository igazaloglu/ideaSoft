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
  public class Category {
    /// <summary>
    /// Kategori nesnesi kimlik değeri.
    /// </summary>
    /// <value>Kategori nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Kategori nesnesi için isim değeri.
    /// </summary>
    /// <value>Kategori nesnesi için isim değeri.</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Slug değeri ilgili nesnenin Url değeridir.
    /// </summary>
    /// <value>Slug değeri ilgili nesnenin Url değeridir.</value>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Kategori nesnesi için sıralama değeri.
    /// </summary>
    /// <value>Kategori nesnesi için sıralama değeri.</value>
    [DataMember(Name="sortOrder", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sortOrder")]
    public int? SortOrder { get; set; }

    /// <summary>
    /// Kategori nesnesinin aktiflik durumunu belirten değer.
    /// </summary>
    /// <value>Kategori nesnesinin aktiflik durumunu belirten değer.</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Kategori nesnesinin fiyat katsayısı.
    /// </summary>
    /// <value>Kategori nesnesinin fiyat katsayısı.</value>
    [DataMember(Name="percent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percent")]
    public float? Percent { get; set; }

    /// <summary>
    /// Kategori nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .JPG, .PNG, .GIF
    /// </summary>
    /// <value>Kategori nesnesinin görselinin dosya adı. Geçerli dosya tipleri: .JPG, .PNG, .GIF</value>
    [DataMember(Name="imageFile", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageFile")]
    public string ImageFile { get; set; }

    /// <summary>
    /// Her zaman null değer alır. Pratikte kullanımı yoktur.
    /// </summary>
    /// <value>Her zaman null değer alır. Pratikte kullanımı yoktur.</value>
    [DataMember(Name="distributor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distributor")]
    public string Distributor { get; set; }

    /// <summary>
    /// Kategori nesnesinin üst içerik metninin gösterim durumu.
    /// </summary>
    /// <value>Kategori nesnesinin üst içerik metninin gösterim durumu.</value>
    [DataMember(Name="displayShowcaseContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "displayShowcaseContent")]
    public int? DisplayShowcaseContent { get; set; }

    /// <summary>
    /// Kategori nesnesinin üst içeriği. Admin paneli üzerinden düzenlenebilir.
    /// </summary>
    /// <value>Kategori nesnesinin üst içeriği. Admin paneli üzerinden düzenlenebilir.</value>
    [DataMember(Name="showcaseContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showcaseContent")]
    public string ShowcaseContent { get; set; }

    /// <summary>
    /// Kategori nesnesinin üst içerik metninin gösterim tipi.<div class='idea_choice_list'><code>1</code> : Kategori içeriği.<br><code>2</code> : Kategori ve üst kategori içeriği.<br><code>3</code> : Kategori ve tüm üst kategoriler.<br></div>
    /// </summary>
    /// <value>Kategori nesnesinin üst içerik metninin gösterim tipi.<div class='idea_choice_list'><code>1</code> : Kategori içeriği.<br><code>2</code> : Kategori ve üst kategori içeriği.<br><code>3</code> : Kategori ve tüm üst kategoriler.<br></div></value>
    [DataMember(Name="showcaseContentDisplayType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showcaseContentDisplayType")]
    public int? ShowcaseContentDisplayType { get; set; }

    /// <summary>
    /// Kategori nesnesinin alt kategori barındırma durumu. Bu değer otomatik oluşturulur.
    /// </summary>
    /// <value>Kategori nesnesinin alt kategori barındırma durumu. Bu değer otomatik oluşturulur.</value>
    [DataMember(Name="hasChildren", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasChildren")]
    public string HasChildren { get; set; }

    /// <summary>
    /// Arama motorları tarafından tespit edilebilecek anahtar kelimeler.
    /// </summary>
    /// <value>Arama motorları tarafından tespit edilebilecek anahtar kelimeler.</value>
    [DataMember(Name="metaKeywords", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metaKeywords")]
    public string MetaKeywords { get; set; }

    /// <summary>
    /// Arama motorları tarafından tespit edilebilecek açıklama yazısı.
    /// </summary>
    /// <value>Arama motorları tarafından tespit edilebilecek açıklama yazısı.</value>
    [DataMember(Name="metaDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metaDescription")]
    public string MetaDescription { get; set; }

    /// <summary>
    /// Kategori nesnesinin etiket başlığı.
    /// </summary>
    /// <value>Kategori nesnesinin etiket başlığı.</value>
    [DataMember(Name="pageTitle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pageTitle")]
    public string PageTitle { get; set; }

    /// <summary>
    /// Üst kategori olan kategori nesnesi.
    /// </summary>
    /// <value>Üst kategori olan kategori nesnesi.</value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public Category Parent { get; set; }

    /// <summary>
    /// Kategori nesnesinin görselinin base64 formatına çevrilmiş resim kodu. PUT ve POST istekleri gerçekleştirlirken başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir.
    /// </summary>
    /// <value>Kategori nesnesinin görselinin base64 formatına çevrilmiş resim kodu. PUT ve POST istekleri gerçekleştirlirken başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir.</value>
    [DataMember(Name="attachment", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "attachment")]
    public string Attachment { get; set; }

    /// <summary>
    /// Kategori nesnesinin oluşturulma zamanı.
    /// </summary>
    /// <value>Kategori nesnesinin oluşturulma zamanı.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Kategori nesnesinin güncellenme zamanı.
    /// </summary>
    /// <value>Kategori nesnesinin güncellenme zamanı.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Category {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Percent: ").Append(Percent).Append("\n");
      sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
      sb.Append("  Distributor: ").Append(Distributor).Append("\n");
      sb.Append("  DisplayShowcaseContent: ").Append(DisplayShowcaseContent).Append("\n");
      sb.Append("  ShowcaseContent: ").Append(ShowcaseContent).Append("\n");
      sb.Append("  ShowcaseContentDisplayType: ").Append(ShowcaseContentDisplayType).Append("\n");
      sb.Append("  HasChildren: ").Append(HasChildren).Append("\n");
      sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
      sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
      sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Attachment: ").Append(Attachment).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
