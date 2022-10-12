using AppliedHttpClient.Providers.Authenticate;
using AppliedHttpClient.Providers.Interfaces;

namespace AppliedHttpClient.Builder
{
  /// <summary>
  /// Конструктор аутентификации.
  /// </summary>
  public partial class RequestBuilder
  {
    /// <summary>
    /// Провайдер аутентификации.
    /// </summary>
    public IAuthenticationProvider AuthenticationProvider { get; set; }

    /// <summary>
    /// Добавить к запросу Basic аутентификацию.
    /// </summary>
    /// <param name="username">Логин.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder Basic(string username, string password)
    {
      this.AuthenticationProvider = new BasicAuthenticationProvider { Password = password, Username = username };

      return this;
    }

    /// <summary>
    /// Добавить к запросу Bearer аутентификацию.
    /// </summary>
    /// <param name="token">Токен.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder Bearer(string token)
    {
      this.AuthenticationProvider = new BearerAuthenticationProvider { Token = token };

      return this;
    }

    /// <summary>
    /// Добавить к запросу NTLM аутентификацию.
    /// </summary>
    /// <param name="username">Логин.</param>
    /// <param name="password">Пароль.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder Ntlm(string username, string password)
    {
      this.AuthenticationProvider = new NtlmAuthenticationProvider { Username = username, Password = password };

      return this;
    }
  }
}
