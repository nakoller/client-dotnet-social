using System;
using System.Net.Http;
using System.Threading.Tasks;
using YelpApi.Client.Auth;
using YelpApi.Client.Extensions;
using YelpApi.Client.Properties;
using YelpApi.Client.V2.Request;
using YelpApi.Client.V2.Result;

namespace YelpApi.Client.V2
{
  /// <summary>
  /// Lightweight client to execute basic queries against the Yelp public API.
  /// </summary>
  public class Client : IDisposable
  {
    private readonly Uri _searchRequestUri;
    private readonly Uri _businessRequestUri;
    private readonly Uri _phoneRequestUri;

    private readonly HttpClient _client;

    /// <summary>
    /// Constructs a client with the default OAuthMessageHandler
    /// </summary>
    public Client() : this(new OAuthMessageHandler()) { } 

    /// <summary>
    /// Constructs a client with the given message handler
    /// </summary>
    /// <param name="messageHandler">The message handler to use when sending requests.</param>
    public Client(HttpMessageHandler messageHandler)
    {
      Uri basePath = new Uri(new Uri(Settings.Default.YelpApiBasePath), "v2/");
      this._searchRequestUri = new Uri(basePath, Settings.Default.SearchRelativePath);
      this._businessRequestUri = new Uri(basePath, Settings.Default.BusinessRelativePath);
      this._phoneRequestUri = new Uri(basePath, Settings.Default.PhoneRelativePath);
      this._client = new HttpClient(messageHandler);
    }

    /// <summary>
    /// Uses the provided parameters to execute a GET query against /v2/search
    /// </summary>
    /// <param name="requestParameters">The request paramers. Valid Search request parameters can be found in YelpAPI.V2.Request.Search and YelpAPI.Request.Common</param>
    /// <returns>The deserialized SearchResult object</returns>
    public async Task<SearchResult> SearchAsync(params object[] requestParameters)
    {
      Uri searchUri = this._searchRequestUri.GenerateUri(requestParameters);
      HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, searchUri);
      string jsonString = await this._client.GetStringAsync(searchUri);
      return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(jsonString);
    }

    /// <summary>
    /// Gets information for a specific business by executing a GET against /v2/business/{business Id}
    /// </summary>
    /// <param name="businessId">The id of the business</param>
    /// <param name="requestParameters">Other request parameters. Valid parameters are found in YelpAPI.V2.Request.Business and YelpAPI.V2.Request.Common. Use others at your own risk</param>
    /// <returns>The deserialized Business object</returns>
    public async Task<Business> SearchBusinessAsync(string businessId, params object[] requestParameters)
    {
      UriBuilder builder = new UriBuilder(string.Format("/{0}", businessId));
      Uri businessUri = new Uri(this._businessRequestUri, string.Format("/{0}", businessId));
      Uri searchUri = businessUri.GenerateUri(requestParameters);
      string jsonString = await this._client.GetStringAsync(searchUri);
      return Newtonsoft.Json.JsonConvert.DeserializeObject<Business>(jsonString);
    }

    /// <summary>
    /// Gets information for a specific service by executing a GET against /v2/phone_search
    /// </summary>
    /// <param name="requestParameters">Request parameters. Valid parameters are found in YelpAPI.V2.Request.Phone. Use others at your own risk</param>
    /// <returns>The deserialized SearchResult object</returns>
    public async Task<SearchResult> SearchPhoneAsync(params object[] requestParameters)
    {
      Uri searchUri = this._phoneRequestUri.GenerateUri(requestParameters);
      HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, searchUri);
      string jsonString = await this._client.GetStringAsync(searchUri);
      return Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(jsonString);
    }

    /// <summary>
    /// Implementing IDisposable
    /// </summary>
    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    /// <summary>
    /// internal dispose method
    /// </summary>
    /// <param name="disposing">If disposing.</param>
    protected virtual void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (this._client != null)
        {
          this._client.Dispose();
        }
      }
    }
  }
}
