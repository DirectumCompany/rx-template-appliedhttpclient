using AppliedHttpClient.Providers.Interfaces;
using System.IO;

namespace AppliedHttpClient.Providers.Body
{
  /// <summary>
  /// XML провайдер тела запроса.
  /// </summary>
  public class XmlBodyProvider : IBodyProvider
  {
    /// <summary>
    /// <see cref="IBodyProvider.Body"/>
    /// </summary>
    public byte[] Body { get; set; }

    /// <summary>
    /// <see cref="IBodyProvider.PathToFile"/>
    /// </summary>
    public string PathToFile { get; set; }

    /// <summary>
    /// <see cref="IBodyProvider.ContentType"/>
    /// </summary>
    public string ContentType()
    {
      return Enums.ContentType.ApplicationXML;
    }

    /// <summary>
    /// <see cref="IBodyProvider.SetBody(Stream)"/>
    /// </summary>
    public void SetBody(Stream requestStream)
    {
      requestStream.Write(this.Body, 0, this.Body.Length);
    }
  }
}
