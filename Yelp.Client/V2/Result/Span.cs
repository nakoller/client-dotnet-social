using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// The span of a Lat-Long combination indicating an area box
  /// </summary>
  public class Span
  {
    /// <summary>
    /// Latitude width of map bounds
    /// </summary>
    [DataMember(Name = "latitude_delta")]
    public double LatitudeDelta { get; set; }

    /// <summary>
    /// Longitude height of map bounds
    /// </summary>
    [DataMember(Name = "longitude_delta")]
    public double LongitudeDelta { get; set; }
  }
}
