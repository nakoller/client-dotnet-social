using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// Information on a Gift Certificate Option
  /// </summary>
  public class GiftCertificateOption
  {
    /// <summary>
    /// Gift certificate option price (in cents)
    /// </summary>
    [DataMember(Name = "price")]
    public uint Price { get; set; }

    /// <summary>
    /// Gift certificate option price (formatted, e.g. "$50")
    /// </summary>
    [DataMember(Name = "formatted_price")]
    public string FormattedPrice { get; set; }
  }
}