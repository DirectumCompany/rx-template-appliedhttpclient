using System.IO;

namespace AppliedHttpClient.Providers.Interfaces
{
  /// <summary>
  /// Провайдер тела запроса.
  /// </summary>
  public interface IBodyProvider
  {
    /// <summary>
    /// Тип отправляемого тела запроса.
    /// </summary>
    /// <returns></returns>
    string ContentType();

    /// <summary>
    /// Добавить к запросу тело.
    /// </summary>
    /// <param name="requestStream">Поток HTTP запроса.</param>
    void SetBody(Stream requestStream);

    /// <summary>
    /// Тело запроса.
    /// </summary>
    byte[] Body { get; set; }

    /// <summary>
    /// Путь до загружаемого файла.
    /// </summary>
    string PathToFile { get; set; }
  }
}
