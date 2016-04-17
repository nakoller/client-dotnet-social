using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// Information on the Options for a Deal
  /// </summary>
  public class DealOption
  {
    /// <summary>
    /// Deal option original price (in cents)
    /// </summary>
    [DataMember(Name = "original_price")]
    public int OriginalPrice { get; set; }

    /// <summary>
    /// Deal option title
    /// </summary>
    [DataMember(Name = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Deal option price (in cents)
    /// </summary>
    [DataMember(Name = "price")]
    public int Price { get; set; }

    /// <summary>
    /// Deal option url for purchase
    /// </summary>
    [DataMember(Name = "purchase_url")]
    public string PurchaseUrl { get; set; }

    /// <summary>
    /// Deal option original price (formatted, e.g. "$12")
    /// </summary>
    [DataMember(Name = "formatted_original_price")]
    public string FormattedOriginalPrice { get; set; }

    /// <summary>
    /// Deal option price (formatted, e.g. "$6")
    /// </summary>
    [DataMember(Name = "formatted_price")]
    public string FormattedPrice { get; set; }

    /// <summary>
    /// Whether the deal option is limited or unlimited
    /// </summary>
    [DataMember(Name = "is_quantity_limited")]
    public bool IsQuantityLimited { get; set; }

    /// <summary>
    /// The remaining deal options available for purchase (optional: this field is only present if the deal is limited)
    /// </summary>
    [DataMember(Name = "remaining_count")]
    public uint RemainingCount { get; set; }
  }
}
