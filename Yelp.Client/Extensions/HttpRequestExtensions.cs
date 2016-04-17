using System;
using System.Linq;
using System.Reflection;

namespace YelpApi.Client.Extensions
{
  /// <summary>
  /// Extensions for the easy creation of parameterized uris
  /// </summary>
  public static class HttpRequestExtensions
  {
    /// <summary>
    /// Genreates a URI based on the baseUri and the parameter objects
    /// 
    /// If the parameter object is decorated with the HttpParameterAttribute, this method will append that parameter as a query
    /// 
    /// if the parameter object has properties decorated with the HttpParameterAttribute, this method will append those properties as a query
    /// </summary>
    /// <param name="baseUri">The base uri</param>
    /// <param name="queryParameters">The query parameter objects to use as query parameters</param>
    /// <returns>The constructed Uri</returns>
    public static Uri GenerateUri(this Uri baseUri, params object[] queryParameters)
    {
      var uriBuilder = new UriBuilder(baseUri);
      if (queryParameters != null && queryParameters.Count() != 0)
      {
        string relativeUri = GenerateRelativeUri(queryParameters);
        uriBuilder.Query = relativeUri;
      }

      return new Uri(uriBuilder.ToString());
    }

    private static string GenerateRelativeUri(params object[] queryParameters)
    {
      var query = System.Web.HttpUtility.ParseQueryString(String.Empty);

      foreach (var queryParameter in queryParameters)
      {
        if (queryParameter == null)
        {
          continue;
        }

        Type paramObjType = queryParameter.GetType();

        HttpParameterAttribute httpParameterAttribute = paramObjType.GetCustomAttribute<HttpParameterAttribute>();
        
        if (paramObjType.HasCustomAttribute<HttpParameterAttribute>())
        {
          HttpParameterAttribute parameterAttr = paramObjType.GetCustomAttribute<HttpParameterAttribute>();
          query[parameterAttr.Parameter] = queryParameter.ToString();
          continue;
        }

        foreach (var property in paramObjType.GetProperties())
        {
          var propertyValue = property.GetValue(queryParameter);
          if (propertyValue == null || !property.HasCustomAttribute<HttpParameterAttribute>())
          {
            continue;
          }
          HttpParameterAttribute parameterAttr = property.GetCustomAttribute<HttpParameterAttribute>();
          query[parameterAttr.Parameter] = propertyValue.ToString();
        }
      }

      return query.ToString();
    }
  }
}
