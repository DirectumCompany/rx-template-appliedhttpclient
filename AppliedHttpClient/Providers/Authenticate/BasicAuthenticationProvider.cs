using AppliedHttpClient.Enums;
using AppliedHttpClient.Providers.Interfaces;
using System;
using System.Text;

namespace AppliedHttpClient.Providers.Authenticate
{
  /// <summary>
  /// Basic провайдер аутентификации.
  /// </summary>
  public class BasicAuthenticationProvider : IAuthenticationProvider
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
    public AuthenticationScheme AuthenticationSchemes { get; set; } = AuthenticationScheme.Basic;

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
      string token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:{1}", this.Username, this.Password)));
      string value = string.Format("{0} {1}", AuthenticationScheme.Basic.ToString(), token);

      return value;
    }
  }
}
