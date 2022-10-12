using AppliedHttpClient.Providers.Interfaces;
using System.Collections.Generic;

namespace AppliedHttpClient.Providers.Headers
{
  /// <summary>
  /// Провайдер заголовоков запроса.
  /// </summary>
  public class HeaderProvider : IHeaderProvider
  {
    /// <summary>
    /// Хранилище заголовков запроса.
    /// </summary>
    private Dictionary<string, string> headers = new Dictionary<string, string>();

    /// <summary>
    /// <see cref="IHeaderProvider.GetHeaders"/>
    /// </summary>
    public IDictionary<string, string> GetHeaders()
    {
      return headers;
    }

    /// <summary>
    /// <see cref="IHeaderProvider.SetHeaders(string, string)"/>
    /// </summary>
    public void SetHeaders(string key, string value)
    {
      this.headers.Add(key, value);
    }

    /// <summary>
    /// <see cref="IHeaderProvider.SetHeaders(IDictionary{string, string})"/>
    /// </summary>
    public void SetHeaders(IDictionary<string, string> headers)
    {
      if (this.headers.Count <= 0)
      {
        this.headers = (Dictionary<string, string>)headers;
      }
    }
  }
}
