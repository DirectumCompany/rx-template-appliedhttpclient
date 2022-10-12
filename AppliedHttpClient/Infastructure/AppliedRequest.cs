using AppliedHttpClient.Enums;
using AppliedHttpClient.Providers.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AppliedHttpClient.Infastructure
{
  /// <summary>
  /// Конструктор прикладного запроса.
  /// </summary>
  public class AppliedRequest
  {
    /// <summary>
    /// Формируемый объет запроса.
    /// </summary>
    private HttpWebRequest httpWebRequest = null;

    /// <summary>
    /// Хранилище сетевых учетных данных.
    /// </summary>
    private readonly CredentialCache credentialCache = new CredentialCache();

    /// <summary>
    /// Прикладной ответ.
    /// </summary>
    private readonly AppliedResponse appliedResponse = new AppliedResponse();

    /// <summary>
    /// Адрес ресурса.
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// Отправляемый HTTP метод.
    /// </summary>
    public HttpMethod Method { get; set; }

    /// <summary>
    /// Провайдер возвращаемых действий.
    /// </summary>
    public IActionProvider ActionProvider { get; set; }

    /// <summary>
    /// Провайдер тела запроса.
    /// </summary>
    public IBodyProvider BodyProvider { get; set; }

    /// <summary>
    /// Провайдер аутентификации.
    /// </summary>
    public IAuthenticationProvider AuthenticationProvider { get; set; }

    /// <summary>
    /// Провайдер заголовков запроса.
    /// </summary>
    public IHeaderProvider HeaderProvider { get; set; }

    /// <summary>
    /// Подготовка и отправка запроса.
    /// </summary>
    public void PrepareAndSend()
    {
      httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(this.Url);
      httpWebRequest.Method = this.Method.ToString().ToUpper();

      if (this.HeaderProvider != null)
      {
        IDictionary<string, string> headers = HeaderProvider.GetHeaders();

        foreach (var header in headers)
        {
          httpWebRequest.Headers.Add(header.Key, header.Value);
        }
      }

      if (this.AuthenticationProvider != null)
      {
        if (this.AuthenticationProvider.AuthenticationTechnique == AuthenticationTechnique.RollYourOwn)
        {
          httpWebRequest.Headers.Add(AuthenticationProvider.GetHeader(), AuthenticationProvider.GetValue());
        }

        if (this.AuthenticationProvider.AuthenticationTechnique == AuthenticationTechnique.NetworkCredentials)
        {
          credentialCache.Add(new Uri(this.Url), this.AuthenticationProvider.AuthenticationSchemes.ToString(), new NetworkCredential(this.AuthenticationProvider.Username, this.AuthenticationProvider.Password));
          httpWebRequest.Credentials = credentialCache;
        }
      }

      if (BodyProvider != null)
      {
        httpWebRequest.ContentType = BodyProvider.ContentType();

        Stream reqStream = httpWebRequest.GetRequestStream();
        BodyProvider.SetBody(reqStream);

        if (BodyProvider.Body.Length > 0)
        {
          httpWebRequest.ContentLength = BodyProvider.Body.Length;
        }
      }

      this.SendHttpWebRequest(httpWebRequest);
    }

    /// <summary>
    /// Отправка запроса.
    /// </summary>
    /// <param name="request">Сфомированный запрос.</param>
    private void SendHttpWebRequest(HttpWebRequest request)
    {
      try
      {
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        this.appliedResponse.StatusCode = response.StatusCode;
        this.appliedResponse.Headers = response.Headers;
        this.appliedResponse.Response = response.GetResponseStream();

        this.ActionProvider.Success(this.appliedResponse);
      }
      catch (WebException ex)
      {
        this.ActionProvider.Fail(ex);
      }
    }
  }
}
