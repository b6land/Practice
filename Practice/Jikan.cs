using Newtonsoft.Json;

public class Jikan{

    private int _AnimeId;
    AnimeDTO? _animeDTO;
    IHttpClient _httpClient;

    /// <summary>
    /// 建構式
    /// </summary>
    /// <param name="animeId"> MAL 網站的動漫編號，預設為 47917 (孤獨搖滾) </param>
    public Jikan(IHttpClient client, int animeId = 47917){
        _httpClient = client;
        _AnimeId = animeId; 

        if(_AnimeId == 0){ // 指定預設值
            _AnimeId = 47917;
        }
    }
    
    /// <summary>
    /// 以非同步方式下載 jikan.moe 網站的 getAnimeById API 內容
    /// </summary>
    public async void Run(){
        string url = @$"https://api.jikan.moe/v4/anime/{_AnimeId}";
        string responseBody = await _httpClient.GetResponseBody(url);
        _animeDTO = GetAnimeInfo(responseBody);

        Console.WriteLine("API 資料:");
        if (_animeDTO != null)
        {
            Console.WriteLine($"基本資料: 標題: {_animeDTO.Title_English}, 年份: {_animeDTO.Year}, 季份: {_animeDTO.Season}, 簡介: {_animeDTO.Synopsis}");
        }

        Console.WriteLine($"原始資料: {responseBody}");
    }

    /// <summary>
    /// 從 JSON 取得動畫資料
    /// </summary>
    /// <param name="body"> 含動畫資料的 JSON 字串 </param>
    /// <returns> AnimeDTO 物件 </returns>
    public AnimeDTO? GetAnimeInfo(string body){
        AnimeDTO? animeDTO = null;

        JikanRoot? deserializedAnime = JsonConvert.DeserializeObject<JikanRoot>(body);

        if (deserializedAnime != null)
        {
            JikanRoot anime = deserializedAnime;

            animeDTO = new AnimeDTO(){
                Title_English = anime.data.title_english,
                Year = anime.data.year,
                Season = anime.data.season,
                Synopsis = anime.data.synopsis
            };
        }

        return animeDTO;
    }
}
