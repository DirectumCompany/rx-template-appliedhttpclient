using AppliedHttpClient.Infastructure;
using System;
using System.IO;
using System.Net;

namespace AppliedHttpClient.Providers.Interfaces
{
  /// <summary>
  /// Провайдер выполняемых методов.
  /// </summary>
  public interface IActionProvider
  {
    /// <summary>
    /// Функция, которая выполнится в случае успешного запроса.
    /// </summary>
   Action<AppliedResponse> Success { get; }

    /// <summary>
    /// Функция, которая выполнится при возникновении ошибки.
    /// </summary>
    Action<WebException> Fail { get; }
  }
}
