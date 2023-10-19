using System.Text;

namespace Practice.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void 測試字串壓縮後是否能正確還原()
    {
        string testStr = "test123";
        StrGZipBase64 gzipBase64 = new StrGZipBase64();
        string zipped = gzipBase64.compress(testStr);
        string unzipped = gzipBase64.decompress(zipped);

        Assert.AreEqual(testStr, unzipped);
    }

    [TestMethod]
    public async Task 測試API_使用Stub()
    {
        RestCountriesStub restCountries = new RestCountriesStub();
        restCountries.ResponseBody = @"[{""name"":{""common"":""Taiwan"",""official"":""Republic of China (Taiwan)"",""nativeName"":{""zho"":{""official"":""中華民國"",""common"":""台灣""}}},""tld"":["".tw"","".台灣"","".台湾""],""cca2"":""TW"",""ccn3"":""158"",""cca3"":""TWN"",""cioc"":""TPE"",""independent"":false,""status"":""officially-assigned"",""unMember"":false,""currencies"":{""TWD"":{""name"":""New Taiwan dollar"",""symbol"":""$""}},""idd"":{""root"":""+8"",""suffixes"":[""86""]},""capital"":[""Taipei""],""altSpellings"":[""TW"",""Táiwān"",""Republic of China"",""中華民國"",""Zhōnghuá Mínguó"",""Chinese Taipei""],""region"":""Asia"",""subregion"":""Eastern Asia"",""languages"":{""zho"":""Chinese""},""translations"":{""ara"":{""official"":""جمهورية الصين (تايوان)"",""common"":""تايوان""},""bre"":{""official"":""Republik Sina (Taiwan)"",""common"":""Taiwan""},""ces"":{""official"":""Čínská republika"",""common"":""Tchaj-wan""},""cym"":{""official"":""Republic of China (Taiwan)"",""common"":""Taiwan""},""deu"":{""official"":""Republik China (Taiwan)"",""common"":""Taiwan""},""est"":{""official"":""Taiwani"",""common"":""Taiwan""},""fin"":{""official"":""Kiinan tasavalta"",""common"":""Taiwan""},""fra"":{""official"":""République de Chine (Taïwan)"",""common"":""Taïwan""},""hrv"":{""official"":""Republika Kina"",""common"":""Tajvan""},""hun"":{""official"":""Kínai Köztársaság"",""common"":""Tajvan""},""ita"":{""official"":""Repubblica cinese (Taiwan)"",""common"":""Taiwan""},""jpn"":{""official"":""中華民国"",""common"":""台湾""},""kor"":{""official"":""중화민국"",""common"":""대만""},""nld"":{""official"":""Republiek China (Taiwan)"",""common"":""Taiwan""},""per"":{""official"":""جمهوری چین"",""common"":""تایوان""},""pol"":{""official"":""Republika Chińska (Tajwan)"",""common"":""Tajwan""},""por"":{""official"":""República da China"",""common"":""Ilha Formosa""},""rus"":{""official"":""Китайская Республика"",""common"":""Тайвань""},""slk"":{""official"":""Čínska republika"",""common"":""Taiwan""},""spa"":{""official"":""República de China en Taiwán"",""common"":""Taiwán""},""srp"":{""official"":""Република Кина"",""common"":""Тајван""},""swe"":{""official"":""Republiken Kina"",""common"":""Taiwan""},""tur"":{""official"":""Çin Cumhuriyeti (Tayvan)"",""common"":""Tayvan""},""urd"":{""official"":""جمہوریہ چین (تائیوان)"",""common"":""تائیوان""}},""latlng"":[23.5,121.0],""landlocked"":false,""area"":36193.0,""demonyms"":{""eng"":{""f"":""Taiwanese"",""m"":""Taiwanese""},""fra"":{""f"":""Taïwanaise"",""m"":""Taïwanais""}},""flag"":""\uD83C\uDDF9\uD83C\uDDFC"",""maps"":{""googleMaps"":""https://goo.gl/maps/HgMKFQjNadF3Wa6B6"",""openStreetMaps"":""https://www.openstreetmap.org/relation/449220""},""population"":23503349,""fifa"":""TPE"",""car"":{""signs"":[""RC""],""side"":""right""},""timezones"":[""UTC+08:00""],""continents"":[""Asia""],""flags"":{""png"":""https://flagcdn.com/w320/tw.png"",""svg"":""https://flagcdn.com/tw.svg""},""coatOfArms"":{""png"":""https://mainfacts.com/media/images/coats_of_arms/tw.png"",""svg"":""https://mainfacts.com/media/images/coats_of_arms/tw.svg""},""startOfWeek"":""monday"",""capitalInfo"":{""latlng"":[25.03,121.52]},""postalCode"":{""format"":""#####"",""regex"":""^(\\d{5})$""}}]";

        string json = await restCountries.GetResponseBody();
        CountryDTO country = restCountries.GetCountryInfo(json);
        Assert.AreEqual("Republic of China (Taiwan)", country.OfficialName);
    }

    [TestMethod]
    public async Task 測試API_使用Mock()
    {
        string url = @$"https://api.jikan.moe/v4/anime/47917";
        Jikan jikan = new Jikan(new MyHttpClientMock());
        string json = await jikan.GetResponseBody(url);
        AnimeDTO? anime = jikan.GetAnimeInfo(json);

        Assert.AreEqual("Bocchi the Rock!", anime?.Title_English);
    }
}