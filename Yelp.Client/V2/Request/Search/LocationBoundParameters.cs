using YelpApi.Client.Properties;

namespace YelpApi.Client.V2.Request.Search
{
  /// <summary>
  /// The information of the location Bounds
  /// </summary>
  [HttpParameter("bounds")]
  public class LocationBoundParameters
  {
    /// <summary>
    /// Southwest latitude of bounding box
    /// </summary>
    public double SouthwestLatitude { get; set; }

    /// <summary>
    /// Southwest longitude of bounding box
    /// </summary>
    public double SouthwestLongitude { get; set; }

    /// <summary>
    /// Northeast latitude of bounding box
    /// </summary>
    public double NortheastLatitude { get; set; }

    /// <summary>
    /// Northeast longitude of bounding box
    /// </summary>
    public double NortheastLongitude { get; set; }

    /// <summary>
    /// Constructs the properly formated LocationBound parameter
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return string.Format("{0},{1}|{2},{3}",
        this.SouthwestLatitude.ToString(Settings.Default.DoubleFormat),
        this.SouthwestLongitude.ToString(Settings.Default.DoubleFormat),
        this.NortheastLatitude.ToString(Settings.Default.DoubleFormat),
        this.NortheastLongitude.ToString(Settings.Default.DoubleFormat));
    }
  }
}
