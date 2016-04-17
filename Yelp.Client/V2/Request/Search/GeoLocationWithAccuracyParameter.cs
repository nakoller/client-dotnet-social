using System.Text;
using YelpApi.Client.Properties;

namespace YelpApi.Client.V2.Request.Search
{
  /// <summary>
  /// Information on a GeoLocation with an option for specifying accuracy and altitude parameters
  /// </summary>
  [HttpParameter("ll")]
  public class GeoLocationWithAccuracyParameter
  {
    /// <summary>
    /// Latitude of geo-point to search near
    /// </summary>
    public double Latitude { get; set; }

    /// <summary>
    /// Longitude of geo-point to search near
    /// </summary>
    public double Longitude { get; set; }

    /// <summary>
    /// Accuracy of latitude, longitude
    /// </summary>
    public double? Accuracy { get; set; }

    /// <summary>
    /// Altitude
    /// </summary>
    public double? Altitude { get; set; }

    /// <summary>
    /// Accuracy of altitude
    /// </summary>
    public double? Altitude_Accuracy { get; set; }

    /// <summary>
    /// Returns the properly forated GeoLocation with Accuracy parameter
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      StringBuilder builder = new StringBuilder();

      builder.AppendFormat("{0},{1}", this.Latitude.ToString(Settings.Default.DoubleFormat), this.Longitude.ToString(Settings.Default.DoubleFormat));

      if (this.Accuracy.HasValue)
      {
        builder.AppendFormat(",{0}", this.Accuracy.Value.ToString(Settings.Default.DoubleFormat));
      }

      if (this.Altitude.HasValue)
      {
        builder.AppendFormat(",{0}", this.Altitude.Value.ToString(Settings.Default.DoubleFormat));
      }

      if (this.Altitude_Accuracy.HasValue)
      {
        builder.AppendFormat(",{0}", this.Altitude_Accuracy.Value.ToString(Settings.Default.DoubleFormat));
      }

      return builder.ToString();
    }
  }
}
