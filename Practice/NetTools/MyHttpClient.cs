using Newtonsoft.Json;
using System.Net;

public class MyHttpClient: IHttpClient
{
    /// <summary>
    /// 以非同步方式下載網站的 API 內容
    /// </summary>
    /// <param name="url"> 網址 </param>
    /// <returns> 內容 </returns>
    public async Task<string> GetResponseBody(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            using(HttpResponseMessage response = client.GetAsync(url).Result){
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }
}