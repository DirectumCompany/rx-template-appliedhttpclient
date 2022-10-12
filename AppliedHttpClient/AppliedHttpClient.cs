using AppliedHttpClient.Builder;

namespace AppliedHttpClient
{
  /// <summary>
  /// Определяет базовые методы запроса.
  /// </summary>
  public static class AppliedHttpClient
  {
    /// <summary>
    /// Отправить Get запрос.
    /// </summary>
    /// <param name="url">Адрес ресурса.</param>
    /// <returns></returns>
    public static RequestBuilder Get(string url)
    {
      return new RequestBuilder(url, Enums.HttpMethod.Get);
    }

    /// <summary>
    /// Отправить Post запрос.
    /// </summary>
    /// <param name="url">Адрес ресурса.</param>
    /// <returns></returns>
    public static RequestBuilder Post(string url)
    {
      return new RequestBuilder(url, Enums.HttpMethod.Post);
    }

    /// <summary>
    /// Отправить Put запрос.
    /// </summary>
    /// <param name="url">Адрес ресурса.</param>
    /// <returns></returns>
    public static RequestBuilder Put(string url)
    {
      return new RequestBuilder(url, Enums.HttpMethod.Put);
    }

    /// <summary>
    /// Отправить Delete запрос.
    /// </summary>
    /// <param name="url">Адрес ресурса.</param>
    /// <returns></returns>
    public static RequestBuilder Delete(string url)
    {
      return new RequestBuilder(url, Enums.HttpMethod.Delete);
    }
  }
}
