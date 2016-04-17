namespace YelpApi.Client.V2.Request.Phone
{
  /// <summary>
  /// phone search parameters
  /// </summary>
  public class PhoneSearchParameters
  {
    /// <summary>
    /// Parameter that specifies the business phone number to search for. 
    /// Outside of the US and Canada, include the international dialing 
    /// code (e.g. +442079460000) or use the 'cc' parameter
    /// </summary>
    [HttpParameter("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// ISO 3166-1 alpha-2 country code. Default country to use when 
    /// parsing the phone number. United States = US, Canada = CA, 
    /// United Kingdom = GB (not UK).
    /// </summary>
    [HttpParameter("cc")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Category to filter search results with. See the list of supported 
    /// categories.
    /// </summary>
    [HttpParameter("category")]
    public string Category { get; set; }
  }
}
