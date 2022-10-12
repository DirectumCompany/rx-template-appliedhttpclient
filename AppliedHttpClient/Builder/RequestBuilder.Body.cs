using AppliedHttpClient.Providers.Body;
using AppliedHttpClient.Providers.Interfaces;
using System;
using System.Text;

namespace AppliedHttpClient.Builder
{
  /// <summary>
  /// Конструктор тела запроса.
  /// </summary>
  public partial class RequestBuilder
  {
    /// <summary>
    /// Провайдер тела запроса.
    /// </summary>
    public IBodyProvider BodyProvider { get; set; }

    /// <summary>
    /// Отправить JSON данные.
    /// </summary>
    /// <param name="content">JSON данные.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder BodyJson(string content)
    {
      return this.SetBody(new JsonBodyProvider { Body = Encoding.UTF8.GetBytes(content)});
    }

    /// <summary>
    /// Отправить XML данные.
    /// </summary>
    /// <param name="content">XML данные.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder BodyXml(string content)
    {
      return this.SetBody(new XmlBodyProvider { Body = Encoding.UTF8.GetBytes(content) });
    }

    /// <summary>
    /// Загрузить файл.
    /// </summary>
    /// <param name="pathToFile">Путь до файла.</param>
    /// <param name="inputFormName">Имя контрола формы.</param>
    /// <returns>Конструктор запроса.</returns>
    public RequestBuilder Upload(string pathToFile, string inputFormName)
    {
      return this.SetBody( new MultipartFormDataContentBodyProvider { PathToFile = pathToFile, FormName = inputFormName });
    }

    /// <summary>
    /// Добавить провайдер тела запроса.
    /// </summary>
    /// <param name="provider">Провайдера тела запроса.</param>
    /// <returns>Конструктор запроса.</returns>
    private RequestBuilder SetBody(IBodyProvider provider)
    {
      if (this.Method == Enums.HttpMethod.Get)
      {
        throw new InvalidOperationException("Невозможно использовать тело запроса при использовании Get запроса");
      }

      this.BodyProvider = provider;
      return this;
    }
  }
}
