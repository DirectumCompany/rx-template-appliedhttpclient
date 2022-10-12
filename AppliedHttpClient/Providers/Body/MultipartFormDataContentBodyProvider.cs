using AppliedHttpClient.Providers.Interfaces;
using System;
using System.IO;

namespace AppliedHttpClient.Providers.Body
{
  /// <summary>
  /// Form-data провайдер тела запроса.
  /// </summary>
  public class MultipartFormDataContentBodyProvider : IBodyProvider
  {
    /// <summary>
    /// Разделитель строк.
    /// </summary>
    private string boundary = string.Format("---------------------------{0}", DateTime.Now.Ticks.ToString("x"));

    /// <summary>
    /// Имя контрола формы.
    /// </summary>
    public string FormName { get; set; }

    /// <summary>
    /// <see cref="IBodyProvider.Body"/>
    /// </summary>
    public byte[] Body { get; set; }

    /// <summary>
    /// <see cref="IBodyProvider.PathToFile"/>
    /// </summary>
    public string PathToFile { get; set; }

    /// <summary>
    /// <see cref="IBodyProvider.SetBody(Stream)"/>
    /// </summary>
    public void SetBody(Stream requestStream)
    {
      string fileName = Path.GetFileName(this.PathToFile);
      this.Body = File.ReadAllBytes(this.PathToFile);

      using (StreamWriter writer = new StreamWriter(requestStream))
      {
        string header = string.Format("\r\n--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\" \r\nContent-Type: application/octet-stream\r\n\r\n", this.boundary, this.FormName, fileName);
        writer.Write(header);
        writer.Flush();

        using (FileStream fileStream = File.OpenRead(this.PathToFile))
        {
          fileStream.CopyToAsync(requestStream);
        }

        writer.Write($"\r\n--{boundary}--\r\n");
      }
    }

    /// <summary>
    /// <see cref="IBodyProvider.ContentType"/>
    /// </summary>
    public string ContentType()
    {
        return string.Format("{0}; boundary={1}", Enums.ContentType.MultipartFormData, this.boundary);
    }
  }
}
