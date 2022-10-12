using AppliedHttpClient.Enums;
using AppliedHttpClient.Providers.Interfaces;

namespace AppliedHttpClient.Providers.Authenticate
{
  /// <summary>
  /// Bearer провайдер аутентификации.
  /// </summary>
  public class BearerAuthenticationProvider : IAuthenticationProvider
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
    public AuthenticationTechnique AuthenticationTechnique { get; set; } = AuthenticationTechnique.RollYourOwn;

    /// <summary>
    /// <see cref="IAuthenticationProvider.AuthenticationSchemes"/>
    /// </summary>
    public AuthenticationScheme AuthenticationSchemes { get; set; } = AuthenticationScheme.Bearer;

    /// <summary>
    /// <see cref="IAuthenticationProvider.GetHeader"/>
    /// </summary>
    public string GetHeader()
    {
      return HttpHeader.Authorization.ToString();
    }

    /// <summary>
    /// <see cref="IAuthenticationProvider.GetValue"/>
    /// </summary>
    public string GetValue()
    {
      string value = string.Format("{0} {1}", AuthenticationScheme.Bearer.ToString(), this.Token);

      return value;
    }
  }
}
