using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// Information on a Gift Certificate
  /// </summary>
  public class GiftCertificate
  {
    /// <summary>
    /// Gift certificate identifier
    /// </summary>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gift certificate landing page url
    /// </summary>
    [DataMember(Name = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Gift certificate image url
    /// </summary>
    [DataMember(Name = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// ISO_4217 Currency Code
    /// </summary>
    [DataMember(Name = "currency_code")]
    public string CurrencyCode { get; set; }

    /// <summary>
    /// Whether unused balances are returned as cash or store credit
    /// </summary>
    [DataMember(Name = "unused_balances")]
    public string UnusedBalances { get; set; }

    /// <summary>
    /// Gift certificate options
    /// </summary>
    [DataMember(Name = "options")]
    public GiftCertificateOption[] Options { get; set; }
  }
}
