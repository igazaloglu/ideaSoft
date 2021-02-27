using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Ymltekstil.IdeaSoft.Server.Base;

namespace Ymltekstil.IdeaSoft.Server.Models.Idea
{


    [DataContract]
    public class Product : ModelBase
    {
        /// <summary>
        /// Ürün nesnesi kimlik değeri.
        /// </summary>
        /// <value>Ürün nesnesi kimlik değeri.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Ürünün adı
        /// </summary>
        /// <value>Ürünün adı</value>
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
        /// Ürünün tam adı. Bu değer bir varyant için ana ürünün adı ve varyant adının birleşiminden oluşur. Örneğin Kırmızı varyantı için Kalem Kırmızı olur.
        /// </summary>
        /// <value>Ürünün tam adı. Bu değer bir varyant için ana ürünün adı ve varyant adının birleşiminden oluşur. Örneğin Kırmızı varyantı için Kalem Kırmızı olur.</value>
        [DataMember(Name = "fullName", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Ürünün stok kodu. ID değeri gibi eşsiz bir kimlik değeridir.
        /// </summary>
        /// <value>Ürünün stok kodu. ID değeri gibi eşsiz bir kimlik değeridir.</value>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "sku")]
        public string Sku { get; set; }

        /// <summary>
        /// Ürünün barkodu.
        /// </summary>
        /// <value>Ürünün barkodu.</value>
        [DataMember(Name = "barcode", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "barcode")]
        public string Barcode { get; set; }

        /// <summary>
        /// Ürünün Fiyat 1 bilgisi.
        /// </summary>
        /// <value>Ürünün Fiyat 1 bilgisi.</value>
        [DataMember(Name = "price1", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "price1")]
        public float? Price1 { get; set; }

        /// <summary>
        /// Ürünün garanti süresi.
        /// </summary>
        /// <value>Ürünün garanti süresi.</value>
        [DataMember(Name = "warranty", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "warranty")]
        public int? Warranty { get; set; }

        /// <summary>
        /// Ürünün KDV oranı.
        /// </summary>
        /// <value>Ürünün KDV oranı.</value>
        [DataMember(Name = "tax", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "tax")]
        public int? Tax { get; set; }

        /// <summary>
        /// Ürünün stok tipi cinsinden miktarı.
        /// </summary>
        /// <value>Ürünün stok tipi cinsinden miktarı.</value>
        [DataMember(Name = "stockAmount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stockAmount")]
        public float? StockAmount { get; set; }

        /// <summary>
        /// Ürünün desisi.
        /// </summary>
        /// <value>Ürünün desisi.</value>
        [DataMember(Name = "volumetricWeight", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "volumetricWeight")]
        public float? VolumetricWeight { get; set; }

        /// <summary>
        /// Ürünün alış fiyatı.
        /// </summary>
        /// <value>Ürünün alış fiyatı.</value>
        [DataMember(Name = "buyingPrice", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "buyingPrice")]
        public float? BuyingPrice { get; set; }

        /// <summary>
        /// Ürünün stok tipi.<div class='idea_choice_list'><code>Piece</code> : Stok tipi birimi Adet<br><code>cm</code> : Stok tipi birimi Santimetre<br><code>Dozen</code> : Stok tipi birimi Düzine<br><code>gram</code> : Stok tipi birimi Gram<br><code>kg</code> : Stok tipi birimi Kilogram<br><code>Person</code> : Stok tipi birimi Kişi<br><code>Package</code> : Stok tipi birimi Paket<br><code>metre</code> : Stok tipi birimi Metre<br><code>m2</code> : Stok tipi birimi Metrekare<br><code>pair</code> : Stok tipi birimi Çift<br></div>
        /// </summary>
        /// <value>Ürünün stok tipi.<div class='idea_choice_list'><code>Piece</code> : Stok tipi birimi Adet<br><code>cm</code> : Stok tipi birimi Santimetre<br><code>Dozen</code> : Stok tipi birimi Düzine<br><code>gram</code> : Stok tipi birimi Gram<br><code>kg</code> : Stok tipi birimi Kilogram<br><code>Person</code> : Stok tipi birimi Kişi<br><code>Package</code> : Stok tipi birimi Paket<br><code>metre</code> : Stok tipi birimi Metre<br><code>m2</code> : Stok tipi birimi Metrekare<br><code>pair</code> : Stok tipi birimi Çift<br></div></value>
        [DataMember(Name = "stockTypeLabel", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "stockTypeLabel")]
        public string StockTypeLabel { get; set; }

        /// <summary>
        /// Ürünün indirim değeri. Örneğin; discountType 1 olursa %5, 0 olursa 5 tl anlamına gelir.
        /// </summary>
        /// <value>Ürünün indirim değeri. Örneğin; discountType 1 olursa %5, 0 olursa 5 tl anlamına gelir.</value>
        [DataMember(Name = "discount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "discount")]
        public float? Discount { get; set; }

        /// <summary>
        /// Ürünün indirim tipini belirtir.<div class='idea_choice_list'><code>1</code> : İndirim yüzdesi<br><code>0</code> : İndirimli fiyat<br></div>
        /// </summary>
        /// <value>Ürünün indirim tipini belirtir.<div class='idea_choice_list'><code>1</code> : İndirim yüzdesi<br><code>0</code> : İndirimli fiyat<br></div></value>
        [DataMember(Name = "discountType", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "discountType")]
        public int? DiscountType { get; set; }

        /// <summary>
        /// Havale indirimi yüzdesi.
        /// </summary>
        /// <value>Havale indirimi yüzdesi.</value>
        [DataMember(Name = "moneyOrderDiscount", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "moneyOrderDiscount")]
        public float? MoneyOrderDiscount { get; set; }

        /// <summary>
        /// Ürün nesnesinin aktiflik durumunu belirten değer.<div class='idea_choice_list'><code>1</code> : Aktif<br><code>0</code> : Pasif<br></div>
        /// </summary>
        /// <value>Ürün nesnesinin aktiflik durumunu belirten değer.<div class='idea_choice_list'><code>1</code> : Aktif<br><code>0</code> : Pasif<br></div></value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Ürün fiyatlarına KDV dahil olup olmadığın belirten değer.<div class='idea_choice_list'><code>1</code> : KDV Dahil<br><code>0</code> : KDV Hariç<br></div>
        /// </summary>
        /// <value>Ürün fiyatlarına KDV dahil olup olmadığın belirten değer.<div class='idea_choice_list'><code>1</code> : KDV Dahil<br><code>0</code> : KDV Hariç<br></div></value>
        [DataMember(Name = "taxIncluded", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "taxIncluded")]
        public string TaxIncluded { get; set; }

        /// <summary>
        /// Ürünün distribütör bilgisi
        /// </summary>
        /// <value>Ürünün distribütör bilgisi</value>
        [DataMember(Name = "distributor", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "distributor")]
        public string Distributor { get; set; }

        /// <summary>
        /// Ürünün hediyeli olup olmadığını belirtir.<div class='idea_choice_list'><code>1</code> : Hediyeli<br><code>0</code> : Hediyeli Değil<br></div>
        /// </summary>
        /// <value>Ürünün hediyeli olup olmadığını belirtir.<div class='idea_choice_list'><code>1</code> : Hediyeli<br><code>0</code> : Hediyeli Değil<br></div></value>
        [DataMember(Name = "isGifted", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "isGifted")]
        public string IsGifted { get; set; }

        /// <summary>
        /// Ürünün yanında hediye olarak vermek istediğiniz hediyeyi bu alanda metin ya da rakamla belirtebilirsiniz.
        /// </summary>
        /// <value>Ürünün yanında hediye olarak vermek istediğiniz hediyeyi bu alanda metin ya da rakamla belirtebilirsiniz.</value>
        [DataMember(Name = "gift", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "gift")]
        public string Gift { get; set; }

        /// <summary>
        /// Kargo ücreti için sistemin kullanılıp kullanılmama değerini belirtir.<div class='idea_choice_list'><code>1</code> : Sistem seçeneği seçili<br><code>0</code> : Sistem seçeneği seçili değil<br></div>
        /// </summary>
        /// <value>Kargo ücreti için sistemin kullanılıp kullanılmama değerini belirtir.<div class='idea_choice_list'><code>1</code> : Sistem seçeneği seçili<br><code>0</code> : Sistem seçeneği seçili değil<br></div></value>
        [DataMember(Name = "customShippingDisabled", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customShippingDisabled")]
        public string CustomShippingDisabled { get; set; }

        /// <summary>
        /// Sistem seçeneği seçilmemişse ürün için girilmesi gereken kargo ücreti.
        /// </summary>
        /// <value>Sistem seçeneği seçilmemişse ürün için girilmesi gereken kargo ücreti.</value>
        [DataMember(Name = "customShippingCost", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "customShippingCost")]
        public float? CustomShippingCost { get; set; }

        /// <summary>
        /// Ürünün piyasa fiyatı
        /// </summary>
        /// <value>Ürünün piyasa fiyatı</value>
        [DataMember(Name = "marketPriceDetail", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "marketPriceDetail")]
        public string MarketPriceDetail { get; set; }

        /// <summary>
        /// Ürün nesnesinin oluşturulma zamanı.
        /// </summary>
        /// <value>Ürün nesnesinin oluşturulma zamanı.</value>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Ürün nesnesinin güncellenme zamanı.
        /// </summary>
        /// <value>Ürün nesnesinin güncellenme zamanı.</value>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "updatedAt")]
        public DateTime? UpdatedAt { get; set; }

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
        /// Ürün nesnesinin etiket başlığı.
        /// </summary>
        /// <value>Ürün nesnesinin etiket başlığı.</value>
        [DataMember(Name = "pageTitle", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "pageTitle")]
        public string PageTitle { get; set; }

        /// <summary>
        /// Ürünün varyantının olup olmadığı değerini belirtir. (API otomatik olarak bu değeri atar.)<div class='idea_choice_list'><code>1</code> : Varyantı var<br><code>0</code> : Varyantı yok<br></div>
        /// </summary>
        /// <value>Ürünün varyantının olup olmadığı değerini belirtir. (API otomatik olarak bu değeri atar.)<div class='idea_choice_list'><code>1</code> : Varyantı var<br><code>0</code> : Varyantı yok<br></div></value>
        [DataMember(Name = "hasOption", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "hasOption")]
        public string HasOption { get; set; }

        /// <summary>
        /// Ürünün kısa açıklaması.
        /// </summary>
        /// <value>Ürünün kısa açıklaması.</value>
        [DataMember(Name = "shortDetails", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "shortDetails")]
        public string ShortDetails { get; set; }

        /// <summary>
        /// Ziyaretçilerinizin site içindeki ürünlerinizin hangi anahtar kelimelerine göre bulacağını belirler.Kelimeler arasında virgül bırakılarak girilmelidir.(etiket1,etiket2)
        /// </summary>
        /// <value>Ziyaretçilerinizin site içindeki ürünlerinizin hangi anahtar kelimelerine göre bulacağını belirler.Kelimeler arasında virgül bırakılarak girilmelidir.(etiket1,etiket2)</value>
        [DataMember(Name = "searchKeywords", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "searchKeywords")]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// Ürüne özel yasal veya isteğe bağlı belirleyebiliceğiniz taksit adedini belirtir. Ürüne özel bir belirleme yapmak istemiyorsanız '-' işareti kullanabilirsiniz.
        /// </summary>
        /// <value>Ürüne özel yasal veya isteğe bağlı belirleyebiliceğiniz taksit adedini belirtir. Ürüne özel bir belirleme yapmak istemiyorsanız '-' işareti kullanabilirsiniz.</value>
        [DataMember(Name = "installmentThreshold", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "installmentThreshold")]
        public string InstallmentThreshold { get; set; }

        /// <summary>
        /// Anasayfa vitrini sırası.
        /// </summary>
        /// <value>Anasayfa vitrini sırası.</value>
        [DataMember(Name = "homeSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "homeSortOrder")]
        public int? HomeSortOrder { get; set; }

        /// <summary>
        /// Popüler ürünler vitrini sırası.
        /// </summary>
        /// <value>Popüler ürünler vitrini sırası.</value>
        [DataMember(Name = "popularSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "popularSortOrder")]
        public int? PopularSortOrder { get; set; }

        /// <summary>
        /// Marka vitrini sırası.
        /// </summary>
        /// <value>Marka vitrini sırası.</value>
        [DataMember(Name = "brandSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "brandSortOrder")]
        public int? BrandSortOrder { get; set; }

        /// <summary>
        /// Sponsor ürünler vitrini sırası
        /// </summary>
        /// <value>Sponsor ürünler vitrini sırası</value>
        [DataMember(Name = "featuredSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "featuredSortOrder")]
        public int? FeaturedSortOrder { get; set; }

        /// <summary>
        /// Kampanyalı ürünler vitrini sırası.
        /// </summary>
        /// <value>Kampanyalı ürünler vitrini sırası.</value>
        [DataMember(Name = "campaignedSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "campaignedSortOrder")]
        public int? CampaignedSortOrder { get; set; }

        /// <summary>
        /// Yeni ürünler vitrini sırası.
        /// </summary>
        /// <value>Yeni ürünler vitrini sırası.</value>
        [DataMember(Name = "newSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "newSortOrder")]
        public int? NewSortOrder { get; set; }

        /// <summary>
        /// İndirimli ürünler vitrini sırası
        /// </summary>
        /// <value>İndirimli ürünler vitrini sırası</value>
        [DataMember(Name = "discountedSortOrder", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "discountedSortOrder")]
        public int? DiscountedSortOrder { get; set; }

        /// <summary>
        /// Marka nesnesi.
        /// </summary>
        /// <value>Marka nesnesi.</value>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "brand")]
        public Brand Brand { get; set; }

        /// <summary>
        /// Kur nesnesi.
        /// </summary>
        /// <value>Kur nesnesi.</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "currency")]
        public Currency Currency { get; set; }

        /// <summary>
        /// Ana ürün olan ürün nesnesi.
        /// </summary>
        /// <value>Ana ürün olan ürün nesnesi.</value>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "parent")]
        public Product Parent { get; set; }

        /// <summary>
        /// Ürün geri sayım bağı nesnesi.
        /// </summary>
        /// <value>Ürün geri sayım bağı nesnesi.</value>
        [DataMember(Name = "countdown", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "countdown")]
        public ProductToCountDown Countdown { get; set; }

        /// <summary>
        /// Ürünün fiyatları.
        /// </summary>
        /// <value>Ürünün fiyatları.</value>
        [DataMember(Name = "prices", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "prices")]
        public List<ProductPrice> Prices { get; set; }

        /// <summary>
        /// Ürünün resimleri.
        /// </summary>
        /// <value>Ürünün resimleri.</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "images")]
        public List<ProductImage> Images { get; set; }

        /// <summary>
        /// Ürünün kategorileri.
        /// </summary>
        /// <value>Ürünün kategorileri.</value>
        [DataMember(Name = "productToCategories", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "productToCategories")]
        public List<ProductToCategory> ProductToCategories { get; set; }
    }
}
