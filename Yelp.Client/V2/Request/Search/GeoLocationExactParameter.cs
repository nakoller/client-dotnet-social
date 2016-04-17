namespace YelpApi.Client.V2.Request.Search
{
  /// <summary>
  /// The GeoLocation parameter for an Exact Geo-Loc
  /// </summary>
  [HttpParameter("cll")]
  public class GeoLocationExactParameter
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
    /// The properly formatted exact geo location parameter value.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return string.Format("{0},{1}", this.Latitude, this.Longitude);
    }
  }
}
