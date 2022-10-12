using AppliedHttpClient.Infastructure;
using AppliedHttpClient.Providers.Interfaces;
using System;
using System.IO;
using System.Net;

namespace AppliedHttpClient.Providers.Action
{
  /// <summary>
  /// Базовый провайдер выполняемых методов.
  /// </summary>
  public class DefaultActoinProvider : IActionProvider
  {
    /// <summary>
    /// <see cref="IActionProvider.Success"/>
    /// </summary>
    public Action<AppliedResponse> Success { get; }

    /// <summary>
    /// <see cref="IActionProvider.Fail"/>
    /// </summary>
    public Action<WebException> Fail { get; }

    /// <summary>
    /// Базовый провайдер действий.
    /// </summary>
    public DefaultActoinProvider(Action<AppliedResponse> success, Action<WebException> fail)
    {
      Success = success;
      Fail = fail;
    }
  }
}
