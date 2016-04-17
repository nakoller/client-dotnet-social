namespace YelpApi.Client.V2.Request.Search
{
  /// <summary>
  /// General search parameters
  /// </summary>
  public class YelpGeneralSearchParameters
  {
    /// <summary>
    /// Search term (e.g. "food", "restaurants"). If term isn’t included 
    /// we search everything. The term keyword also accepts business names
    /// such as "Starbucks".
    /// </summary>
    [HttpParameter("term")]
    public string Term { get; set; }

    /// <summary>
    /// Number of business results to return
    /// </summary>
    [HttpParameter("limit")]
    public uint? Limit { get; set; }
    
    /// <summary>
    /// Offset the list of returned business results by this amount
    /// </summary>
    [HttpParameter("offset")]
    public uint? Offset { get; set; }

    /// <summary>
    /// Sort mode: 0=Best matched (default), 1=Distance, 2=Highest Rated. 
    /// If the mode is 1 or 2 a search may retrieve an additional 20 businesses 
    /// past the initial limit of the first 20 results. This is done by 
    /// specifying an offset and limit of 20. Sort by distance is only 
    /// supported for a location or geographic search. The rating sort is 
    /// not strictly sorted by the rating value, but by an adjusted rating 
    /// value that takes into account the number of ratings, similar to a
    /// bayesian average. This is so a business with 1 rating of 5 stars 
    /// doesn’t immediately jump to the top.
    /// </summary>
    [HttpParameter("sort")]
    public int? Sort { get; set; }

    /// <summary>
    /// Category to filter search results with. See the list of supported 
    /// categories. The category filter can be a list of comma delimited 
    /// categories. For example, 'bars,french' will filter by Bars and 
    /// French. The category identifier should be used (for example 
    /// 'discgolf', not 'Disc Golf').
    /// </summary>
    [HttpParameter("category_filter")]
    public string CategoryFilter { get; set; }

    /// <summary>
    /// Search radius in meters. If the value is too large, a 
    /// AREA_TOO_LARGE error may be returned. The max value is 40000 
    /// meters (25 miles).
    /// </summary>
    [HttpParameter("radius_filter")]
    public uint? RadiusFilter { get; set; }

    /// <summary>
    /// Whether to exclusively search for businesses with deals
    /// </summary>
    [HttpParameter("deals_filter")]
    public bool? DealsFilter { get; set; }
  }
}