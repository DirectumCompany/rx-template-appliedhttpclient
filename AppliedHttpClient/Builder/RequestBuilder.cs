using AppliedHttpClient.Enums;
using AppliedHttpClient.Infastructure;
using AppliedHttpClient.Providers.Action;

namespace AppliedHttpClient.Builder
{
  /// <summary>
  /// Конструктор запроса.
  /// </summary>
  public partial class RequestBuilder
  {
    /// <summary>
    /// Адрес ресурса.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Отправляемый HTTP метод.
    /// </summary>
    public HttpMethod Method { get; set; }

    /// <summary>
    /// Конструктор.
    /// </summary>
    /// <param name="url">Адрес ресурса.</param>
    /// <param name="method">Отправляемый HTTP метод.</param>
    public RequestBuilder(string url, HttpMethod method)
    {
      Url = url;
      Method = method;
    }

    /// <summary>
    /// Отправить запрос.
    /// </summary>
    public void Send()
    {
      if (this.ActionProvider == null)
      {
        this.ActionProvider = new DefaultActoinProvider(this.success, this.fail);
      }

      AppliedRequest request = new AppliedRequest
      {
        Url = Url,
        Method = Method,
        ActionProvider = ActionProvider,
        BodyProvider = BodyProvider,
        AuthenticationProvider= AuthenticationProvider,
        HeaderProvider = HeaderProvider
      };

      request.PrepareAndSend();
    }
  }
}
