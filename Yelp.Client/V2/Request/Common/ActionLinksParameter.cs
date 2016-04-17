namespace YelpApi.Client.V2.Request.Common
{
  /// <summary>
  /// Whether Include links to actionable content if available
  /// </summary>
  [HttpParameter("actionlinks")]
  public class ActionLinksParameter
  {
    /// <summary>
    /// constructs an ActionLinksParameter object given the actionLinks value
    /// </summary>
    /// <param name="actionLinks"></param>
    public static implicit operator ActionLinksParameter(bool actionLinks)
    {
      return new ActionLinksParameter() { ActionLinks = actionLinks };
    }

    /// <summary>
    /// returns the ActionLinks property of the given parameter
    /// </summary>
    /// <param name="parameter"></param>
    public static implicit operator bool(ActionLinksParameter parameter)
    {
      return parameter.ActionLinks;
    }

    /// <summary>
    /// True if action links are to be provided with results. False or omitted otherwise
    /// </summary>
    public bool ActionLinks { get; set; }

    /// <summary>
    /// The value of teh ActionLinks query parameter
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return this.ActionLinks.ToString();
    }
  }
}
