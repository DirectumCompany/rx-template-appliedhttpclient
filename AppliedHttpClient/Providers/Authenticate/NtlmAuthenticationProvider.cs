using AppliedHttpClient.Enums;
using AppliedHttpClient.Providers.Interfaces;

namespace AppliedHttpClient.Providers.Authenticate
{
  /// <summary>
  /// NTLM провайдер аутентификации.
  /// </summary>
  public class NtlmAuthenticationProvider : IAuthenticationProvider
  {
    /// <summary>
    /// <see cref="IAuthenticationProvider.Username"/>
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// <see cref="IAuthenticationProvider.Password"/>
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// <see cref="IAuthenticationProvider.Token"/>
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// <see cref="IAuthenticationProvider.AuthenticationTechnique"/>
    /// </summary>
    public AuthenticationTechnique AuthenticationTechnique { get; set; } = AuthenticationTechnique.NetworkCredentials;

    /// <summary>
    /// <see cref="IAuthenticationProvider.AuthenticationSchemes"/>
    /// </summary>
    public AuthenticationScheme AuthenticationSchemes { get; set; } = AuthenticationScheme.NTLM;

    /// <summary>
    /// <see cref="IAuthenticationProvider.GetHeader"/>
    /// </summary>
    public string GetHeader()
    {
      throw new System.NotImplementedException();
    }

    /// <summary>
    /// <see cref="IAuthenticationProvider.GetValue"/>
    /// </summary>
    public string GetValue()
    {
      throw new System.NotImplementedException();
    }
  }
}
