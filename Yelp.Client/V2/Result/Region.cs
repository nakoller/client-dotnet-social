using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// A region - a Coordinate and Span pair creating a geographicly bounded box.
  /// </summary>
  public class Region
  {
    /// <summary>
    /// Span of suggested map bounds
    /// </summary>
    [DataMember(Name = "span")]
    public Span Span { get; set; }

    /// <summary>
    /// Center position of map bounds
    /// </summary>
    [DataMember(Name = "center")]
    public Coordinate Center { get; set; }
  }
}
