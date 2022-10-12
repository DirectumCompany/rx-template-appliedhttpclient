using System;
using System.IO;
using System.Text.Json;

namespace AppliedHttpClientApp
{
  internal class Program
  {
    private class Product
    {
      public int id { get; set; }
      public string homepage { get; set; }
      public string description { get; set; }
    }

    static void Main(string[] args)
    {
      string content = "{\"homepage\": \"dir.com\",\"description\": \"online dir\"}";
      Product product = null;
      string testResult = string.Empty;
      string pathToFile = @"D:\TestDoc.docx";
      string token = "eyJraWQiOiItSE5TUmtwMWdXcG9QcC1wWVBmU1U4UW1fdng4Q0VwdzRSdTZTQU9WLThRIiwiYWxnIjoiUlMyNTYifQ.eyJ2ZXIiOjEsImp0aSI6IkFULmRZSXE2S3lSNHJWbzJtUlRBS2c0VW0yRWZ1aGxtbnVBSHlQakM0eGlXQzgub2FydXV3enF0T3ZLdm5sSHk0eDYiLCJpc3MiOiJodHRwczovL2Rldi00NTc5MzEub2t0YS5jb20vb2F1dGgyL2F1c2hkNGM5NVF0RkhzZld0NHg2IiwiYXVkIjoiYXBpIiwiaWF0IjoxNjYwODA5NDY1LCJleHAiOjE2NjA4MTMwNjUsImNpZCI6IjBvYWhkaGprdXRhR2NJSzJNNHg2IiwidWlkIjoiMDB1aGVuaDFwVkRNZzJ1ZXg0eDYiLCJzY3AiOlsib2ZmbGluZV9hY2Nlc3MiXSwiYXV0aF90aW1lIjoxNjYwODA5NDY1LCJzdWIiOiJhcGktdXNlcjRAaXd0Lm5ldCJ9.BBa0dkbDGM9eY-F4suCKySkhaiG47Y6w-aR2cAqMtHJ93q9xQKBSUlg02zOgfG-k5Ds8rJOtOKNfuwK0U-Rk7dhYF76b3eBJVRlivoRkjEH-RGzm7ZHH68-lKnwK6WoubH1h-qF_irQ6IxfrJAQoAxAejU7vqdA-cpNUzMnxaOsWrBNihfBVrZ5jpGT7azWVfyp45vhptDAN6wscwbAj1CKxup0y7LAGeEXe7hOD2Np0imoQOIUZ_9R1L8qo62De5M-pexovA5brouuRji6cuQGUtfxedhFB2pMbf1u3zTN8nygzvu_JOrWlNoOQqaI6vTD8_O_bPXJa2fkLJIjSRw";
      string token2 = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1lIjoiYWRtaW4iLCJleHAiOjE2NjExNjY3MjAsImlzcyI6Imh0dHBzOi8vbXl3ZWJhcGkuY29tIiwiYXVkIjoiTXkgV2ViQXBpIFVzZXJzIn0.o1cYK3Xqa291A4Q1vhaK_FAYkKOsaHrFVIsyLl0GQRE";

      // Header
      //AppliedHttpClient.AppliedHtttpClient.Get("")
      //.Headers("Token", "ji(#grtash$#@gffsdhueHe[,adasnuWJ!br#gey*ie8366heGye#6egd#Uerg")
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.OnSuccess((result) =>
      //{
      //  using (StreamReader sr = new StreamReader(result.Response))
      //  {
      //    Console.WriteLine(sr.ReadToEnd());
      //  }
      //})
      //.Send();

      // Basic
      //AppliedHttpClient.AppliedHtttpClient.Get("https://localhost:57345/api/Values/basic")
      //.Basic("admin", "admin")
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.OnSuccess((result) =>
      //{
      //  using (StreamReader sr = new StreamReader(result.Response))
      //  {
      //    Console.WriteLine(sr.ReadToEnd());
      //  }
      //})
      //.Send();

      // Bearer
      //AppliedHttpClient.AppliedHtttpClient.Get("https://api.instantwebtools.net/v2/airlines")
      //AppliedHttpClient.AppliedHtttpClient.Get("https://localhost:57345/api/Values/jwt")
      //.Bearer(token2)
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.OnSuccess((result) =>
      //{
      //  using (StreamReader sr = new StreamReader(result.Response))
      //  {
      //    Console.WriteLine(sr.ReadToEnd());
      //  }
      //})
      //.Send();

      // NTLM
      //AppliedHttpClient.AppliedHtttpClient.Get("https://localhost:57345/api/Values/jwt")
      //.Ntlm("login", "password")
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.OnSuccess((heders, result) =>
      //{
      //  using (StreamReader sr = new StreamReader(result))
      //  {
      //    Console.WriteLine(sr.ReadToEnd());
      //  }
      //})
      //.Send();

      //AppliedHttpClient.AppliedHtttpClient.Post("https://v2.convertapi.com/upload")
      // Отправка файла
      //AppliedHttpClient.AppliedHtttpClient.Post("http://localhost:5000/weatherforecast/upload")
      //.Upload(pathToFile, "file")
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.OnSuccess((heders, result) =>
      //{
      //  using (StreamReader sr = new StreamReader(result))
      //  {
      //    Console.WriteLine(sr.ReadToEnd());
      //  }
      //})
      //.Send();

      // Получение продукта
      AppliedHttpClient.AppliedHttpClient.Get("https://www.onlinetool.in/api/products/2/")
      .OnSuccess(result =>
      {
        using (StreamReader sr = new StreamReader(result.Response))
        {
          product = JsonSerializer.Deserialize<Product>(sr.ReadToEnd());
        }
      })
      .OnFail(result =>
      {
        Console.WriteLine(result);
      })
      .Send();

      //AppliedHttpClient.AppliedHtttpClient.Get("http://localhost:5000/weatherforecast").OnSuccess(result =>
      //{
      //  product = JsonSerializer.Deserialize<Product>(result);
      //})
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.Send();

      // Изменение продукта
      //product.homepage = "test Homepage";
      //product.description = "test Description";

      //AppliedHttpClient.AppliedHtttpClient.Put($"https://www.onlinetool.in/api/products/{product.id}")
      //.BodyJson(JsonSerializer.Serialize<Product>(product))
      //.OnSuccess(result =>
      //{
      //  testResult = result;
      //})
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result);
      //})
      //.Send();

      // Удаление продукта
      //AppliedHttpClient.AppliedHtttpClient.Delete($"https://www.onlinetool.in/api/products/{product.id}")
      //.OnSuccess(result =>
      //{
      //  testResult = result;
      //}).Send();

      //AppliedHttpClient.AppliedHtttpClient.Get("https://www.onlinetool.in/api/products/")
      //.BodyJson(content)
      //.OnSuccess((heders, result) =>
      //{
      //  using (StreamReader sr = new StreamReader(result))
      //  {
      //    Console.WriteLine(sr.ReadToEnd());
      //  }
      //})
      //.OnFail(result =>
      //{
      //  Console.WriteLine(result.Message);
      //})
      //.Send();
    }
  }
}
