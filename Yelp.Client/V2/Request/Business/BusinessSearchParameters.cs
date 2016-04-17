namespace YelpApi.Client.V2.Request.Business
{
  /// <summary>
  /// Information on Business Search Parameters
  /// </summary>
  public class BusinessSearchParameters
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

    /// <summary>
    /// Whether to filter business reviews by the specified lang
    /// </summary>
    [HttpParameter("lang_filter")]
    public bool LanguageFilter { get; set; }
  }
}
