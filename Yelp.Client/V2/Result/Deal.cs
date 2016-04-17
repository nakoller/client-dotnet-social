using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// Info about a Deal
  /// </summary>
  public class Deal
  {
    /// <summary>
    /// Whether the Deal is popular
    /// </summary>
    [DataMember(Name = "is_popular")]
    public bool IsPopular { get; set; }

    /// <summary>
    /// Additional details for the Deal, separated by newlines
    /// </summary>
    [DataMember(Name = "what_you_get")]
    public string WhatYouGet { get; set; }

    /// <summary>
    /// Deal start time (Unix timestamp)
    /// </summary>
    [DataMember(Name = "time_start")]
    public ulong TimeStart { get; set; }

    /// <summary>
    /// Deal end time (optional: this field is present only if the Deal ends)
    /// </summary>
    [DataMember(Name = "time_end")]
    public ulong? TimeEnd { get; set; }

    /// <summary>
    /// Deal title
    /// </summary>
    [DataMember(Name = "title")]
    public string Title { get; set; }

    /// <summary>
    /// Deal url
    /// </summary>
    [DataMember(Name = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Important restrictions for the Deal, separated by newlines
    /// </summary>
    [DataMember(Name = "important_restrictions")]
    public string ImportantRestrictions { get; set; }

    /// <summary>
    /// Deal additional restrictions
    /// </summary>
    [DataMember(Name = "additional_restrictions")]
    public string AdditionalRestrictions { get; set; }

    /// <summary>
    /// Deal options
    /// </summary>
    [DataMember(Name = "options")]
    public DealOption[] Options { get; set; }

    /// <summary>
    /// Deal image url
    /// </summary>
    [DataMember(Name = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// Deal identifier
    /// </summary>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// ISO_4217 Currency Code
    /// </summary>
    [DataMember(Name = "currency_code")]
    public string CurrencyCode { get; set; }
  }
}
