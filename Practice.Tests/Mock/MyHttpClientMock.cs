
public class MyHttpClientMock : IHttpClient{
    public Task<string> GetResponseBody(string url)
    {
        if(url.Equals("https://api.jikan.moe/v4/anime/47917")){
            string result = @"{""data"":{""mal_id"":47917,""url"":""https:\/\/myanimelist.net\/anime\/47917\/Bocchi_the_Rock"",""images"":{""jpg"":{""image_url"":""https:\/\/cdn.myanimelist.net\/images\/anime\/1448\/127956.jpg"",""small_image_url"":""https:\/\/cdn.myanimelist.net\/images\/anime\/1448\/127956t.jpg"",""large_image_url"":""https:\/\/cdn.myanimelist.net\/images\/anime\/1448\/127956l.jpg""},""webp"":{""image_url"":""https:\/\/cdn.myanimelist.net\/images\/anime\/1448\/127956.webp"",""small_image_url"":""https:\/\/cdn.myanimelist.net\/images\/anime\/1448\/127956t.webp"",""large_image_url"":""https:\/\/cdn.myanimelist.net\/images\/anime\/1448\/127956l.webp""}},""trailer"":{""youtube_id"":""Fp7lnCp_LW0"",""url"":""https:\/\/www.youtube.com\/watch?v=Fp7lnCp_LW0"",""embed_url"":""https:\/\/www.youtube.com\/embed\/Fp7lnCp_LW0?enablejsapi=1&wmode=opaque&autoplay=1"",""images"":{""image_url"":""https:\/\/img.youtube.com\/vi\/Fp7lnCp_LW0\/default.jpg"",""small_image_url"":""https:\/\/img.youtube.com\/vi\/Fp7lnCp_LW0\/sddefault.jpg"",""medium_image_url"":""https:\/\/img.youtube.com\/vi\/Fp7lnCp_LW0\/mqdefault.jpg"",""large_image_url"":""https:\/\/img.youtube.com\/vi\/Fp7lnCp_LW0\/hqdefault.jpg"",""maximum_image_url"":""https:\/\/img.youtube.com\/vi\/Fp7lnCp_LW0\/maxresdefault.jpg""}},""approved"":true,""titles"":[{""type"":""Default"",""title"":""Bocchi the Rock!""},{""type"":""Japanese"",""title"":""\u307c\u3063\u3061\u30fb\u3056\u30fb\u308d\u3063\u304f\uff01""},{""type"":""English"",""title"":""Bocchi the Rock!""}],""title"":""Bocchi the Rock!"",""title_english"":""Bocchi the Rock!"",""title_japanese"":""\u307c\u3063\u3061\u30fb\u3056\u30fb\u308d\u3063\u304f\uff01"",""title_synonyms"":[],""type"":""TV"",""source"":""4-koma manga"",""episodes"":12,""status"":""Finished Airing"",""airing"":false,""aired"":{""from"":""2022-10-09T00:00:00+00:00"",""to"":""2022-12-25T00:00:00+00:00"",""prop"":{""from"":{""day"":9,""month"":10,""year"":2022},""to"":{""day"":25,""month"":12,""year"":2022}},""string"":""Oct 9, 2022 to Dec 25, 2022""},""duration"":""23 min per ep"",""rating"":""PG-13 - Teens 13 or older"",""score"":8.82,""scored_by"":286592,""rank"":28,""popularity"":444,""members"":483144,""favorites"":23593,""synopsis"":""Yearning to make friends and perform live with a band, lonely and socially anxious Hitori \""Bocchi\"" Gotou devotes her time to playing the guitar. On a fateful day, Bocchi meets the outgoing drummer Nijika Ijichi, who invites her to join Kessoku Band when their guitarist, Ikuyo Kita, flees before their first show. Soon after, Bocchi meets her final bandmate\u2014the cool bassist Ryou Yamada. \n\nAlthough their first performance together is subpar, the girls feel empowered by their shared love for music, and they are soon rejoined by Kita. Finding happiness in performing, Bocchi and her bandmates put their hearts into improving as musicians while making the most of their fleeting high school days.\n\n[Written by MAL Rewrite]"",""background"":""Bocchi the Rock! was released on Blu-ray and DVD in six volumes from December 28, 2022, to May 24, 2023."",""season"":""fall"",""year"":2022,""broadcast"":{""day"":""Sundays"",""time"":""00:00"",""timezone"":""Asia\/Tokyo"",""string"":""Sundays at 00:00 (JST)""},""producers"":[{""mal_id"":17,""type"":""anime"",""name"":""Aniplex"",""url"":""https:\/\/myanimelist.net\/anime\/producer\/17\/Aniplex""},{""mal_id"":797,""type"":""anime"",""name"":""Houbunsha"",""url"":""https:\/\/myanimelist.net\/anime\/producer\/797\/Houbunsha""}],""licensors"":[],""studios"":[{""mal_id"":1835,""type"":""anime"",""name"":""CloverWorks"",""url"":""https:\/\/myanimelist.net\/anime\/producer\/1835\/CloverWorks""}],""genres"":[{""mal_id"":4,""type"":""anime"",""name"":""Comedy"",""url"":""https:\/\/myanimelist.net\/anime\/genre\/4\/Comedy""}],""explicit_genres"":[],""themes"":[{""mal_id"":52,""type"":""anime"",""name"":""CGDCT"",""url"":""https:\/\/myanimelist.net\/anime\/genre\/52\/CGDCT""},{""mal_id"":19,""type"":""anime"",""name"":""Music"",""url"":""https:\/\/myanimelist.net\/anime\/genre\/19\/Music""}],""demographics"":[]}}";
            return Task.FromResult(result);
        }

        return Task.FromResult(string.Empty);
    }
}