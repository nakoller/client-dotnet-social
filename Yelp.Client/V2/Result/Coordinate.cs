using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// A Geographical Coordinate
  /// </summary>
  public class Coordinate
  {
    /// <summary>
    /// Latitude associated with the location. "coordinate" may be omitted 
    /// if none is known for the location.
    /// </summary>
    [DataMember(Name = "latitude")]
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude associated with the location. "coordinate" may be omitted 
    /// if none is known for the location.
    /// </summary>
    [DataMember(Name = "longitude")]
    public double Longitude { get; set; }
  }
}
