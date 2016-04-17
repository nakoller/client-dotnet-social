using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// The location of a business
  /// </summary>
  public class Location
  {
    /// <summary>
    /// Address for this business. Only includes address fields.
    /// </summary>
    [DataMember(Name = "address")]
    public string[] Address { get; set; }

    /// <summary>
    /// City for this business
    /// </summary>
    [DataMember(Name = "city")]
    public string City { get; set; }

    /// <summary>
    /// Coordinates of this location. This will be omitted if coordinates 
    /// are not known for the location.
    /// </summary>
    [DataMember(Name = "coordinate")]
    public Coordinate Coordinate { get; set; }

    /// <summary>
    /// ISO 3166-1 country code for this business
    /// </summary>
    [DataMember(Name = "country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Cross streets for this business
    /// </summary>
    [DataMember(Name = "cross_streets")]
    public string CrossStreets { get; set; }

    /// <summary>
    /// Address for this business formatted for display. Includes all 
    /// address fields, cross streets and city, state_code, etc.
    /// </summary>
    [DataMember(Name = "display_address")]
    public string[] DisplayAddress { get; set; }

    /// <summary>
    /// The geolocation accuracy. Honestly, this wasn't on Yelp's API page but it's in the json so... ¯\_(ツ)_/¯
    /// </summary>
    [DataMember(Name = "geo_accuracy")]
    public double GeoAccuracy { get; set; }

    /// <summary>
    /// List that provides neighborhood(s) information for business
    /// </summary>
    [DataMember(Name = "neighborhoods")]
    public string[] Neighborhoods { get; set; }

    /// <summary>
    /// Postal code for this business
    /// </summary>
    [DataMember(Name = "postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// ISO 3166-2 state code for this business
    /// </summary>
    [DataMember(Name = "state_code")]
    public string StateCode { get; set; }
  }
}
