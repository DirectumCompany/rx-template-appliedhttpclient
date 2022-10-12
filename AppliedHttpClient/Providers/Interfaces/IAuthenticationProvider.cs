using AppliedHttpClient.Enums;

namespace AppliedHttpClient.Providers.Interfaces
{
  /// <summary>
  /// Провайдер аутентификации.
  /// </summary>
  public interface IAuthenticationProvider
  {
    /// <summary>
    /// Имя пользователя учетной записи.
    /// </summary>
    string Username { get; set; }

    /// <summary>
    /// Пароль учетной записи.
    /// </summary>
    string Password { get; set; }

    /// <summary>
    /// Токен для Bearer аутентификации.
    /// </summary>
    string Token { get; set; }

    /// <summary>
    /// Технология аутентификации.
    /// </summary>
    AuthenticationTechnique AuthenticationTechnique { get; set; }

    /// <summary>
    /// Схема аутентификации.
    /// </summary>
    AuthenticationScheme AuthenticationSchemes { get; set; }

    /// <summary>
    /// HTTP заголовок аутентификации.
    /// </summary>
    /// <returns></returns>
    string GetHeader();

    /// <summary>
    /// Значение HTTP заголовока аутентификации.
    /// </summary>
    /// <returns></returns>
    string GetValue();
  }
}