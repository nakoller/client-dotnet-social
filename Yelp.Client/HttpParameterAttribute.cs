using System;

namespace YelpApi.Client
{
  internal class HttpParameterAttribute : Attribute
  {
    internal HttpParameterAttribute(string parameter)
    {
      this.Parameter = parameter;
    }

    /// <summary>
    /// The parameter in the query
    /// </summary>
    internal string Parameter { get; private set; }
  }
}