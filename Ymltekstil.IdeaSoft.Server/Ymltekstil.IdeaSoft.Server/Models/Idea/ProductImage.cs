using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class ProductImage
    {
        /// <summary>
        /// Ürün resmi nesnesi kimlik değeri.
        /// </summary>
        /// <value>Ürün resmi nesnesi kimlik değeri.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Ürün resminin dosya adı. Uzantı olmadan yazılmalıdır.
        /// </summary>
        /// <value>Ürün resminin dosya adı. Uzantı olmadan yazılmalıdır.</value>
        [DataMember(Name = "filename", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "filename")]
        public string Filename { get; set; }

        /// <summary>
        /// Resim için geçerli dosya uzantıları.<div class='idea_choice_list'><code>jpg</code> : jpg dosyaları için geçerli uzantı.<br><code>png</code> : png dosyaları için geçerli uzantı.<br><code>gif</code> : gif dosyaları için geçerli uzantı.<br><code>jpeg</code> : jpeg dosyaları için geçerli uzantı.<br></div>
        /// </summary>
        /// <value>Resim için geçerli dosya uzantıları.<div class='idea_choice_list'><code>jpg</code> : jpg dosyaları için geçerli uzantı.<br><code>png</code> : png dosyaları için geçerli uzantı.<br><code>gif</code> : gif dosyaları için geçerli uzantı.<br><code>jpeg</code> : jpeg dosyaları için geçerli uzantı.<br></div></value>
        [DataMember(Name = "extension", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "extension")]
        public string Extension { get; set; }

        /// <summary>
        /// Dosya konumu adı. API otomatik oluşturur.
        /// </summary>
        /// <value>Dosya konumu adı. API otomatik oluşturur.</value>
        [DataMember(Name = "directoryName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "directoryName")]
        public string DirectoryName { get; set; }

        /// <summary>
        /// Revision değeri aynı isimle eklediğiniz resimlerin ön bellekten yüklenmesini engellemek için gerekli bir değerdir. Aynı isimle tekrardan resim yüklenirken bir önceki resimden farklı bir değer almalıdır.
        /// </summary>
        /// <value>Revision değeri aynı isimle eklediğiniz resimlerin ön bellekten yüklenmesini engellemek için gerekli bir değerdir. Aynı isimle tekrardan resim yüklenirken bir önceki resimden farklı bir değer almalıdır.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "revision")]
        public string Revision { get; set; }

        /// <summary>
        /// Resmin sıralama değeri. Ürün içerisindeki 8 fotoğraf içinden hangisi olacağını belirler.
        /// </summary>
        /// <value>Resmin sıralama değeri. Ürün içerisindeki 8 fotoğraf içinden hangisi olacağını belirler.</value>
        [DataMember(Name = "sortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sortOrder")]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Ürün nesnesi.
        /// </summary>
        /// <value>Ürün nesnesi.</value>
        [DataMember(Name = "product", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "product")]
        public Product Product { get; set; }

        /// <summary>
        /// Ürün resminin base64 formatına çevrilmiş resim kodu. Oluşturma(POST) isteği esnasında başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir.
        /// </summary>
        /// <value>Ürün resminin base64 formatına çevrilmiş resim kodu. Oluşturma(POST) isteği esnasında başında data:image/jpeg;base64, ibaresi bulunmak zorundadır. GET isteği esnasında bu değer görüntülenmeyecektir.</value>
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "attachment")]
        public string Attachment { get; set; }
    }
}


