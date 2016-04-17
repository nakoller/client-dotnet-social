using SimpleOAuth;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using YelpApi.Client.Properties;

namespace YelpApi.Client.Auth
{
  /// <summary>
  /// Message handler to add the OAuth header to a WebRequest before sending
  /// </summary>
  public class OAuthMessageHandler : DelegatingHandler
  {
    private readonly string _consumerKey;
    private readonly string _consumerSecret;
    private readonly string _token;
    private readonly string _tokenSecret;
    private readonly EncryptionMethod _encryptionMethod;

    /// <summary>
    /// Constructs a default message handler base on settings in app.config
    /// By default, the delegate handler is HttpClientHandler()
    /// </summary>
    public OAuthMessageHandler() : this(
      Settings.Default.ConsumerKey,
      Settings.Default.ConsumerSecret,
      Settings.Default.Token,
      Settings.Default.TokenSecret,
      Settings.Default.EncryptionMethod,
      new HttpClientHandler())
    {

    }

    /// <summary>
    /// constructs a handler based on the provided consumer key, secret, token, token secret and encryption method.
    /// By default, the delegate handler is HttpClientHandler()
    /// </summary>
    /// <param name="consumerKey">Your consumer key</param>
    /// <param name="consumerSecret">Your consumer Secret</param>
    /// <param name="token">Your token</param>
    /// <param name="tokenSecret">Your token secret</param>
    /// <param name="encryptionMethod">Your encyrption method</param>
    public OAuthMessageHandler(string consumerKey, string consumerSecret, string token, string tokenSecret, string encryptionMethod) : this(
      consumerKey,
      consumerSecret,
      token,
      tokenSecret,
      encryptionMethod,
      new HttpClientHandler())
    {
    }

    /// <summary>
    /// constructs a handler based on the provided consumer key, secret, token, token secret and encryption method
    /// </summary>
    /// <param name="consumerKey">Your consumer key</param>
    /// <param name="consumerSecret">Your consumer Secret</param>
    /// <param name="token">Your token</param>
    /// <param name="tokenSecret">Your token secret</param>
    /// <param name="encryptionMethod">Your encyrption method</param>
    /// <param name="innerHandler">Your delegate handler</param>
    public OAuthMessageHandler(string consumerKey, string consumerSecret, string token, string tokenSecret, string encryptionMethod, HttpMessageHandler innerHandler) : base(innerHandler)
    {
      this._consumerKey = consumerKey;
      this._consumerSecret = consumerSecret;
      this._token = token;
      this._tokenSecret = tokenSecret;
      this._encryptionMethod = (EncryptionMethod)Enum.Parse(typeof(EncryptionMethod), encryptionMethod);
    }
    
    /// <summary>
    /// Adds the OAuth token and sends the request using the inner handler
    /// </summary>
    /// <param name="request">The request to authorize and send</param>
    /// <param name="cancellationToken">Cancellation token (to be passed to the inner handler)</param>
    /// <returns>The HttpResponseMessage</returns>
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
      WebRequest webRequest = HttpWebRequest.Create(request.RequestUri);
      webRequest.SignRequest(new Tokens()
      {
        AccessToken = this._token,
        AccessTokenSecret = this._tokenSecret,
        ConsumerKey = this._consumerKey,
        ConsumerSecret = this._consumerSecret
      }).WithEncryption(this._encryptionMethod).InHeader();

      var authHeader = webRequest.Headers["Authorization"];
      request.Headers.Add("Authorization", authHeader);
      return await base.SendAsync(request, cancellationToken);
    }
  }
}
