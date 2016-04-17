using System.Runtime.Serialization;

namespace YelpApi.Client.V2.Result
{
  /// <summary>
  /// The results of a basic or phone search.
  /// </summary>
  public class SearchResult
  {
    /// <summary>
    /// Suggested bounds in a map to display results in
    /// </summary>
    [DataMember(Name = "region")]
    public Region Region { get; set; }

    /// <summary>
    /// The list of business entries (see Business)
    /// </summary>
    [DataMember(Name = "businesses")]
    public Business[] Businesses { get; set; }

    /// <summary>
    /// Total number of business results
    /// </summary>
    [DataMember(Name = "total")]
    public int Total { get; set; }
  }
}