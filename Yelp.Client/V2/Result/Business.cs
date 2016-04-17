using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// Information on a business
  /// </summary>
  public class Business
  {
    /// <summary>
    /// Provides a list of category name, alias pairs that this business 
    /// is associated with. For example, [["Local Flavor", "localflavor"],
    /// ["Active Life", "active"], ["Mass Media", "massmedia"]] The alias 
    /// is provided so you can search with the category_filter.
    /// </summary>
    [DataMember(Name = "categories")]
    public string[][] Categories { get; set; }

    /// <summary>
    /// Phone number for this business formatted for display
    /// </summary>
    [DataMember(Name = "display_phone")]
    public string DisplayPhone { get; set; }

    /// <summary>
    /// Yelp ID for this business
    /// </summary>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// URL of photo for this business
    /// </summary>
    [DataMember(Name = "image_url")]
    public string ImageUri { get; set; }

    /// <summary>
    /// Whether business has been claimed by a business owner
    /// </summary>
    [DataMember(Name = "is_claimed")]
    public bool IsClaimed { get; set; }

    /// <summary>
    /// Whether business has been (permanently) closed
    /// </summary>
    [DataMember(Name = "is_closed")]
    public bool IsClosed { get; set; }

    /// <summary>
    /// Location data for this business
    /// </summary>
    [DataMember(Name = "location")]
    public Location Location { get; set; }

    /// <summary>
    /// URL for mobile business page on Yelp
    /// </summary>
    [DataMember(Name = "mobile_url")]
    public string MobileUrl { get; set; }

    /// <summary>
    /// Name of this business
    /// </summary>
    [DataMember(Name = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Phone number for this business with international dialing code 
    /// (e.g. +442079460000)
    /// </summary>
    [DataMember(Name = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Rating for this business (value ranges from 1, 1.5, ... 4.5, 5)
    /// </summary>
    [DataMember(Name = "rating")]
    public double Rating { get; set; }

    /// <summary>
    /// URL to star rating image for this business (size = 84x17)
    /// </summary>
    [DataMember(Name = "rating_img_url")]
    public string RatingImageUrl { get; set; }

    /// <summary>
    /// URL to large version of rating image for this business (size = 166x30)
    /// </summary>
    [DataMember(Name = "rating_img_url_large")]
    public string RatingImageUrlLarge { get; set; }

    /// <summary>
    /// URL to small version of rating image for this business (size = 50x10)
    /// </summary>
    [DataMember(Name = "rating_img_url_small")]
    public string RatingImageUrlSmall { get; set; }

    /// <summary>
    /// Number of reviews for this business
    /// </summary>
    [DataMember(Name = "review_count")]
    public int ReviewCount { get; set; }

    /// <summary>
    /// URL of snippet image associated with this business
    /// </summary>
    [DataMember(Name = "snippet_image_url")]
    public string SnippedImageUrl { get; set; }

    /// <summary>
    /// Snippet text associated with this business
    /// </summary>
    [DataMember(Name = "snippet_text")]
    public string SnippedText { get; set; }

    /// <summary>
    /// URL for business page on Yelp
    /// </summary>
    [DataMember(Name = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Deal info for this business (optional: this field is present only 
    /// if there’s a Deal)
    /// </summary>
    [DataMember(Name = "deals")]
    public Deal[] Deals { get; set; }

    /// <summary>
    /// Gift certificate info for this business (optional: this field is 
    /// present only if there are gift certificates available)
    /// </summary>
    [DataMember(Name = "gift_certificates")]
    public GiftCertificate[] GiftCertificates { get; set; }

    /// <summary>
    /// Provider of the menu for this business
    /// </summary>
    [DataMember(Name = "menu_provider")]
    public string MenuProvider { get; set; }

    /// <summary>
    /// Last time this menu was updated on Yelp (Unix timestamp)
    /// </summary>
    [DataMember(Name = "menu_date_updated")]
    public ulong MenuDateUpdated { get; set; }

    /// <summary>
    /// URL to the SeatMe reservation page for this business. This key 
    /// will not be present if the business does not take reservations 
    /// through SeatMe or if the query param 'actionlinks' is not set to 
    /// True in the request
    /// </summary>
    [DataMember(Name = "reservation_url")]
    public string ReservationUrl { get; set; }

    /// <summary>
    /// URL to the Eat24 page for this business. This key will not be 
    /// present if the business does not offer delivery through Eat24 or 
    /// if the query param 'actionlinks' is not set to True in the request
    /// </summary>
    [DataMember(Name = "eat24_url")]
    public string Eat24Url { get; set; }

    /// <summary>
    /// Contains reviews associated with business
    /// </summary>
    [DataMember(Name = "reviews")]
    public Review[] Reviews { get; set; }
  }
}
