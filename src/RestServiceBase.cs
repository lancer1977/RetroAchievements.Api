namespace PolyhydraGames.RetroAchievements;

public class RestServiceBase
{
    protected ICheevoAuth AuthConfig { get; set; }
    private readonly HttpClient _client;
    public const string BaseUrl = "https://retroachievements.org/API";
    protected string GetBaseUrl([CallerMemberName] string memberName = "")
    {
        var url = BaseUrl + "/API_" + memberName + ".php?";
        return url.ApiKey(AuthConfig.ApiKey).AuthUser(AuthConfig.UserName);
    }
    public RestServiceBase(ICheevoAuth config, HttpClient client)
    {
        AuthConfig = config;
        _client = client;
    }
    //protected readonly IHttpService _httpService;

    protected bool AuthRequired { get; set; }

    protected JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions()
    {
        PropertyNameCaseInsensitive = true,
        Converters = { new CustomDateFormatConverter() }
    };


#if NET6_0_OR_GREATER
    protected Uri Uri(string query)
    {
        DefaultInterpolatedStringHandler interpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
        interpolatedStringHandler.AppendFormatted(BaseUrl);
        interpolatedStringHandler.AppendLiteral("/");
        interpolatedStringHandler.AppendFormatted(query);
        return new System.Uri(interpolatedStringHandler.ToStringAndClear());
    }
#else
    protected Uri Uri(string query)
    {
        return new Uri(BaseUrl + "/" + query);
    }
#endif

    private Exception OnUnauthorized()
    {
        return new Exception(this.AuthRequired
            ? "Unauthorized"
            : "AuthRequired was not enabled, but the endpoint claims that authorization is required. Did you miss setting AuthRequired?");
    }

    protected async Task<T?> Get<T>(string url)
    {
        Debug.WriteLine(url);
        HttpClient client = this._client;
        HttpResponseMessage httpResponseMessage = await client.GetAsync(url);

        if (httpResponseMessage.IsSuccessStatusCode)
        {
            var responseString = await httpResponseMessage.Content.ReadAsStringAsync();
            Debug.WriteLine(responseString);
            try
            {
                T obj = JsonSerializer.Deserialize<T>(responseString, this.Options);
                return obj;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(responseString);
                Debug.WriteLine(ex.ToString());
                throw;
            }
        }

        if (httpResponseMessage.StatusCode == HttpStatusCode.Unauthorized)
            throw this.OnUnauthorized();
        throw new Exception(httpResponseMessage.StatusCode.ToString() + ":" + httpResponseMessage.ReasonPhrase);
    }

    protected async Task<HttpRequestMessage> GetHttpRequestMessage(string method, HttpMethod httpMethod, HttpContent content = null)
    {
        return new HttpRequestMessage()
        {
            RequestUri = this.Uri(method),
            Method = httpMethod,
            Content = content
        };
    }

}