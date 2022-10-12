using System.IO;
using System.Net;

namespace AppliedHttpClient.Infastructure
{
  /// <summary>
  /// Прикладной ответ.
  /// </summary>
  public class AppliedResponse
  {
    /// <summary>
    /// Статус код ответа.
    /// </summary>
    public HttpStatusCode StatusCode { get; set; }

    /// <summary>
    /// HTTP заголовки ответа.
    /// </summary>
    public WebHeaderCollection Headers { get; set; }

    /// <summary>
    /// Поток содержащий ответ.
    /// </summary>
    public Stream Response { get; set; }
  }
}
