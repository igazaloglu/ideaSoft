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
  public class Member {
    /// <summary>
    /// Üye nesnesi kimlik değeri.
    /// </summary>
    /// <value>Üye nesnesi kimlik değeri.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public int? Id { get; set; }

    /// <summary>
    /// Üyenin ismi.
    /// </summary>
    /// <value>Üyenin ismi.</value>
    [DataMember(Name="firstname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstname")]
    public string Firstname { get; set; }

    /// <summary>
    /// Üyenin soy ismi.
    /// </summary>
    /// <value>Üyenin soy ismi.</value>
    [DataMember(Name="surname", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surname")]
    public string Surname { get; set; }

    /// <summary>
    /// Üyenin e-mail adresi.
    /// </summary>
    /// <value>Üyenin e-mail adresi.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Üyenin cinsiyet bilgisi.<div class='idea_choice_list'><code>male</code> : Erkek<br><code>female</code> : Kadın<br></div>
    /// </summary>
    /// <value>Üyenin cinsiyet bilgisi.<div class='idea_choice_list'><code>male</code> : Erkek<br><code>female</code> : Kadın<br></div></value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Üyenin doğum tarihi.
    /// </summary>
    /// <value>Üyenin doğum tarihi.</value>
    [DataMember(Name="birthDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "birthDate")]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Üyenin telefon numarası.
    /// </summary>
    /// <value>Üyenin telefon numarası.</value>
    [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phoneNumber")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Üyenin mobil telefon numarası.
    /// </summary>
    /// <value>Üyenin mobil telefon numarası.</value>
    [DataMember(Name="mobilePhoneNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mobilePhoneNumber")]
    public string MobilePhoneNumber { get; set; }

    /// <summary>
    /// Üyenin diğer şehir bilgileri.
    /// </summary>
    /// <value>Üyenin diğer şehir bilgileri.</value>
    [DataMember(Name="otherLocation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "otherLocation")]
    public string OtherLocation { get; set; }

    /// <summary>
    /// Üyenin adres bilgileri.
    /// </summary>
    /// <value>Üyenin adres bilgileri.</value>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Üyenin vergi numarası.
    /// </summary>
    /// <value>Üyenin vergi numarası.</value>
    [DataMember(Name="taxNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxNumber")]
    public string TaxNumber { get; set; }

    /// <summary>
    /// Üyenin TC kimlik numarası.
    /// </summary>
    /// <value>Üyenin TC kimlik numarası.</value>
    [DataMember(Name="tcId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tcId")]
    public string TcId { get; set; }

    /// <summary>
    /// Üyenin durum bilgisi.<div class='idea_choice_list'><code>queue</code> : Sırada<br><code>active</code> : Aktif<br><code>passive</code> : Pasif<br><code>suspended</code> : Askıda<br></div>
    /// </summary>
    /// <value>Üyenin durum bilgisi.<div class='idea_choice_list'><code>queue</code> : Sırada<br><code>active</code> : Aktif<br><code>passive</code> : Pasif<br><code>suspended</code> : Askıda<br></div></value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Üyenin son giriş yaptığı tarih.
    /// </summary>
    /// <value>Üyenin son giriş yaptığı tarih.</value>
    [DataMember(Name="lastLoginDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastLoginDate")]
    public DateTime? LastLoginDate { get; set; }

    /// <summary>
    /// Üye nesnesinin oluşturulma zamanı.
    /// </summary>
    /// <value>Üye nesnesinin oluşturulma zamanı.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Üye nesnesinin güncellenme zamanı.
    /// </summary>
    /// <value>Üye nesnesinin güncellenme zamanı.</value>
    [DataMember(Name="updatedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "updatedAt")]
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// Üyenin posta kodu.
    /// </summary>
    /// <value>Üyenin posta kodu.</value>
    [DataMember(Name="zipCode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipCode")]
    public string ZipCode { get; set; }

    /// <summary>
    /// Üyenin kurumsal adı.
    /// </summary>
    /// <value>Üyenin kurumsal adı.</value>
    [DataMember(Name="commercialName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commercialName")]
    public string CommercialName { get; set; }

    /// <summary>
    /// Üyenin vergi dairesi.
    /// </summary>
    /// <value>Üyenin vergi dairesi.</value>
    [DataMember(Name="taxOffice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "taxOffice")]
    public string TaxOffice { get; set; }

    /// <summary>
    /// Üyeye gönderilen son e-mail tarihi.
    /// </summary>
    /// <value>Üyeye gönderilen son e-mail tarihi.</value>
    [DataMember(Name="lastMailSentDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastMailSentDate")]
    public DateTime? LastMailSentDate { get; set; }

    /// <summary>
    /// Üyenin en son giriş yaptığı IP adresi.
    /// </summary>
    /// <value>Üyenin en son giriş yaptığı IP adresi.</value>
    [DataMember(Name="lastIp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastIp")]
    public string LastIp { get; set; }

    /// <summary>
    /// Üyenin kazandığı puan tutarı.
    /// </summary>
    /// <value>Üyenin kazandığı puan tutarı.</value>
    [DataMember(Name="gainedPointAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gainedPointAmount")]
    public float? GainedPointAmount { get; set; }

    /// <summary>
    /// Üyenin harcadığı puan tutarı.
    /// </summary>
    /// <value>Üyenin harcadığı puan tutarı.</value>
    [DataMember(Name="spentPointAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "spentPointAmount")]
    public float? SpentPointAmount { get; set; }

    /// <summary>
    /// Üyenin kampanyalara katılım için izin durumu.<div class='idea_choice_list'><code>1</code> : Kampanyalar için izinli.<br><code>0</code> : Kampanyalar için izinsiz.<br></div>
    /// </summary>
    /// <value>Üyenin kampanyalara katılım için izin durumu.<div class='idea_choice_list'><code>1</code> : Kampanyalar için izinli.<br><code>0</code> : Kampanyalar için izinsiz.<br></div></value>
    [DataMember(Name="allowedToCampaigns", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowedToCampaigns")]
    public string AllowedToCampaigns { get; set; }

    /// <summary>
    /// Üyenin tavsiye ettiği kişilerden dolayı kazandığı puan.
    /// </summary>
    /// <value>Üyenin tavsiye ettiği kişilerden dolayı kazandığı puan.</value>
    [DataMember(Name="referredMemberGainedPointAmount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referredMemberGainedPointAmount")]
    public float? ReferredMemberGainedPointAmount { get; set; }

    /// <summary>
    /// Üyenin ilçesi.
    /// </summary>
    /// <value>Üyenin ilçesi.</value>
    [DataMember(Name="district", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "district")]
    public string District { get; set; }

    /// <summary>
    /// Üyenin kullandığı cihaz tipi.
    /// </summary>
    /// <value>Üyenin kullandığı cihaz tipi.</value>
    [DataMember(Name="deviceType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceType")]
    public string DeviceType { get; set; }

    /// <summary>
    /// Üyenin kullandığı cihaz bilgisi.
    /// </summary>
    /// <value>Üyenin kullandığı cihaz bilgisi.</value>
    [DataMember(Name="deviceInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deviceInfo")]
    public string DeviceInfo { get; set; }

    /// <summary>
    /// Ülke nesnesi.
    /// </summary>
    /// <value>Ülke nesnesi.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public Country Country { get; set; }

    /// <summary>
    /// Şehir nesnesi.
    /// </summary>
    /// <value>Şehir nesnesi.</value>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public Location Location { get; set; }

    /// <summary>
    /// Üye grubu nesnesi.
    /// </summary>
    /// <value>Üye grubu nesnesi.</value>
    [DataMember(Name="memberGroup", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "memberGroup")]
    public MemberGroup MemberGroup { get; set; }

    /// <summary>
    /// Üyeyi tavsiye eden üye nesnesi.
    /// </summary>
    /// <value>Üyeyi tavsiye eden üye nesnesi.</value>
    [DataMember(Name="referredMember", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referredMember")]
    public Member ReferredMember { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Member {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Firstname: ").Append(Firstname).Append("\n");
      sb.Append("  Surname: ").Append(Surname).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  MobilePhoneNumber: ").Append(MobilePhoneNumber).Append("\n");
      sb.Append("  OtherLocation: ").Append(OtherLocation).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
      sb.Append("  TcId: ").Append(TcId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  LastLoginDate: ").Append(LastLoginDate).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
      sb.Append("  ZipCode: ").Append(ZipCode).Append("\n");
      sb.Append("  CommercialName: ").Append(CommercialName).Append("\n");
      sb.Append("  TaxOffice: ").Append(TaxOffice).Append("\n");
      sb.Append("  LastMailSentDate: ").Append(LastMailSentDate).Append("\n");
      sb.Append("  LastIp: ").Append(LastIp).Append("\n");
      sb.Append("  GainedPointAmount: ").Append(GainedPointAmount).Append("\n");
      sb.Append("  SpentPointAmount: ").Append(SpentPointAmount).Append("\n");
      sb.Append("  AllowedToCampaigns: ").Append(AllowedToCampaigns).Append("\n");
      sb.Append("  ReferredMemberGainedPointAmount: ").Append(ReferredMemberGainedPointAmount).Append("\n");
      sb.Append("  District: ").Append(District).Append("\n");
      sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
      sb.Append("  DeviceInfo: ").Append(DeviceInfo).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  MemberGroup: ").Append(MemberGroup).Append("\n");
      sb.Append("  ReferredMember: ").Append(ReferredMember).Append("\n");
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
