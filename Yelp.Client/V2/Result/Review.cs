using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// A review of a business
  /// </summary>
  public class Review
  {
    /// <summary>
    /// Review excerpt
    /// </summary>
    [DataMember(Name = "excerpt")]
    public string Excerpt { get; set; }

    /// <summary>
    /// Review identifier
    /// </summary>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Rating from 1-5
    /// </summary>
    [DataMember(Name = "rating")]
    public ushort Rating { get; set; }

    /// <summary>
    /// URL to large version of rating image for this business (size = 166x30)
    /// </summary>
    [DataMember(Name = "rating_image_large_url")]
    public string RatingImageLargeUrl { get; set; }

    /// <summary>
    /// URL to small version of rating image for this business (size = 50x10)
    /// </summary>
    [DataMember(Name = "rating_image_small_url")]
    public string RatingImageSmallUrl { get; set; }

    /// <summary>
    /// URL to star rating image for this business (size = 84x17)
    /// </summary>
    [DataMember(Name = "rating_image_url")]
    public string RatingImageUrl { get; set; }

    /// <summary>
    /// Time created (Unix timestamp)
    /// </summary>
    [DataMember(Name = "time_created")]
    public int TimeCreated { get; set; }

    /// <summary>
    /// User who wrote the review
    /// </summary>
    [DataMember(Name = "user")]
    public User User { get; set; }
  }
}
