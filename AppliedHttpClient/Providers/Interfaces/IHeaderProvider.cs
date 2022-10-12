using System.Collections.Generic;

namespace AppliedHttpClient.Providers.Interfaces
{
  /// <summary>
  /// Провайдер заголовков запроса.
  /// </summary>
  public interface IHeaderProvider
  {
    /// <summary>
    /// Получить заголовки запроса.
    /// </summary>
    /// <returns></returns>
    IDictionary<string, string> GetHeaders();

    /// <summary>
    /// Добавить заголовок запроса.
    /// </summary>
    /// <param name="key">Имя заголовка.</param>
    /// <param name="value">Значение заголовока.</param>
    void SetHeaders(string key, string value);

    /// <summary>
    /// Добавить заголовки запроса.
    /// </summary>
    /// <param name="headers">Словарь заголовков.</param>
    void SetHeaders(IDictionary<string, string> headers);
  }
}
