using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// Information about a user
  /// </summary>
  public class User
  {
    /// <summary>
    /// User identifier
    /// </summary>
    [DataMember(Name = "id")]
    public string Id { get; set; }

    /// <summary>
    /// User profile image url
    /// </summary>
    [DataMember(Name = "image_url")]
    public string ImageUrl { get; set; }

    /// <summary>
    /// User name
    /// </summary>
    [DataMember(Name = "name")]
    public string Name { get; set; }
  }
}
