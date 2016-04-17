namespace YelpApi.Client.V2.Request.Search
{
  /// <summary>
  /// The Location 
  /// </summary>
  [HttpParameter("location")]
  public class LocationParameter
  {
    /// <summary>
    /// Specifies the combination of "address, neighborhood, city, state or zip, optional country" to be used when searching for businesses.
    /// </summary>
    public string LocationString { get; set; }

    /// <summary>
    /// Creates a new LocationParameter based on the given location string
    /// </summary>
    /// <param name="location">The location to create</param>
    public static implicit operator LocationParameter(string location)
    {
      return new LocationParameter()
      {
        LocationString = location
      };
    }

    /// <summary>
    /// returns the location string
    /// </summary>
    /// <param name="location"></param>
    public static implicit operator string(LocationParameter location)
    {
      return location.LocationString;
    }

    /// <summary>
    /// Returns the location string
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return LocationString;
    }
  }
}
