using AppliedHttpClient.Providers.Headers;
using AppliedHttpClient.Providers.Interfaces;
using System.Collections.Generic;

namespace AppliedHttpClient.Builder
{
  /// <summary>
  /// Конструктор заголовков запроса.
  /// </summary>
  public partial class RequestBuilder
  {
    /// <summary>
    /// Провайдер заголовков запроса.
    /// </summary>
    public IHeaderProvider HeaderProvider { get; set; }

    /// <summary>
    /// Добавить заголовок к запросу.
    /// </summary>
    /// <param name="key">Имя заголовка.</param>
    /// <param name="value">Значение заголовока.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder Headers(string key, string value)
    {
      if (this.HeaderProvider == null)
      {
        this.HeaderProvider = new HeaderProvider();
      }

      this.HeaderProvider.SetHeaders(key, value);

      return this;
    }

    /// <summary>
    /// Добавить заголовки к запроса.
    /// </summary>
    /// <param name="headers">Словарь заголовоков.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder Headers(Dictionary<string, string> headers)
    {
      if (this.HeaderProvider == null)
      {
        this.HeaderProvider = new HeaderProvider();
      }

      this.HeaderProvider.SetHeaders(headers);

      return this;
    }
  }
}
