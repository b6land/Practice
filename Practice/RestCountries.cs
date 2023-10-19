using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
public class RestCountries
{
    CountryDTO? countryDTO;

    /// <summary>
    /// 從 RestCountries.com 呼叫 API
    /// </summary>
    public async void Run()
    {
        string responseBody = await GetResponseBody();
        countryDTO = GetCountryInfo(responseBody);

        Console.WriteLine("API 資料:");
        if (countryDTO != null)
        {
            Console.WriteLine($"基本資料: 國名: {countryDTO.Name}, 首都: {countryDTO.Capital}, 地區: {countryDTO.Region}, 人口數: {countryDTO.Population}");
        }

        Console.WriteLine($"原始資料: {responseBody}");
    }

    /// <summary>
    /// 以非同步方式下載 RestCountries.com 的 Capital API 內容
    /// </summary>
    /// <returns> JSON 字串 </returns>
    public virtual async Task<string> GetResponseBody(){
        using (HttpClient client = new HttpClient())
        {
            ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            string url = @"https://restcountries.com/v3.1/capital/taipei";
            using(HttpResponseMessage response = client.GetAsync(url).Result){
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
    }

    /// <summary>
    /// 從 JSON 取得國家資料
    /// </summary>
    /// <param name="body"> 含國家資料的 JSON 字串 </param>
    /// <returns> CountryDTO 物件 </returns>
    public CountryDTO? GetCountryInfo(string body){
        CountryDTO? countryDTO = null;

        List<Root>? deserializedCountry = JsonConvert.DeserializeObject<List<Root>>(body);

        if (deserializedCountry != null && deserializedCountry.Count > 0)
        {
            Root country = deserializedCountry[0];

            countryDTO = new CountryDTO(){
                Name = country.name.common,
                OfficialName = country.name.official,
                Capital = country.capital[0],
                Region = country.region,
                Population = country.population
            };
        }

        return countryDTO;
    }
}

