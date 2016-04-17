namespace YelpApi.Client.V2.Request.Search
{
  /// <summary>
  /// Information about the Locale
  /// </summary>
  public class LocaleParameters
  {
    /// <summary>
    /// ISO 3166-1 alpha-2 country code. Default country to use when parsing the location field. United States = US, Canada = CA, United Kingdom = GB (not UK).
    /// </summary>
    [HttpParameter("cc")]
    public string CountryCode { get; set; }

    /// <summary>
    /// ISO 639 language code (default=en). Reviews and snippets written in the specified language will be shown.
    /// </summary>
    [HttpParameter("lang")]
    public string Language { get; set; }
  }
}
