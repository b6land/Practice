/* 由 Jikan 取得的 JSON 動畫資料 */

#pragma warning disable CS8618 // 此類別不啟用 CS8618 警告
public class Aired
{
    public DateTime from { get; set; }
    public DateTime to { get; set; }
    public Prop prop { get; set; }
    public string @string { get; set; }
}

public class Broadcast
{
    public string day { get; set; }
    public string time { get; set; }
    public string timezone { get; set; }
    public string @string { get; set; }
}

public class Data
{
    public int mal_id { get; set; }
    public string url { get; set; }
    public Images images { get; set; }
    public Trailer trailer { get; set; }
    public bool approved { get; set; }
    public List<Title> titles { get; set; }
    public string title { get; set; }
    public string title_english { get; set; }
    public string title_japanese { get; set; }
    public List<object> title_synonyms { get; set; }
    public string type { get; set; }
    public string source { get; set; }
    public int episodes { get; set; }
    public string status { get; set; }
    public bool airing { get; set; }
    public Aired aired { get; set; }
    public string duration { get; set; }
    public string rating { get; set; }
    public double score { get; set; }
    public int scored_by { get; set; }
    public int rank { get; set; }
    public int popularity { get; set; }
    public int members { get; set; }
    public int favorites { get; set; }
    public string synopsis { get; set; }
    public string background { get; set; }
    public string season { get; set; }
    public int year { get; set; }
    public Broadcast broadcast { get; set; }
    public List<Producer> producers { get; set; }
    public List<object> licensors { get; set; }
    public List<Studio> studios { get; set; }
    public List<Genre> genres { get; set; }
    public List<object> explicit_genres { get; set; }
    public List<Theme> themes { get; set; }
    public List<object> demographics { get; set; }
}

public class From
{
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }
}

public class Genre
{
    public int mal_id { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public string url { get; set; }
}

public class Images
{
    public Jpg jpg { get; set; }
    public Webp webp { get; set; }
    public string image_url { get; set; }
    public string small_image_url { get; set; }
    public string medium_image_url { get; set; }
    public string large_image_url { get; set; }
    public string maximum_image_url { get; set; }
}

public class Jpg
{
    public string image_url { get; set; }
    public string small_image_url { get; set; }
    public string large_image_url { get; set; }
}

public class Producer
{
    public int mal_id { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public string url { get; set; }
}

public class Prop
{
    public From from { get; set; }
    public To to { get; set; }
}

public class JikanRoot
{
    public Data data { get; set; }
}

public class Studio
{
    public int mal_id { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public string url { get; set; }
}

public class Theme
{
    public int mal_id { get; set; }
    public string type { get; set; }
    public string name { get; set; }
    public string url { get; set; }
}

public class Title
{
    public string type { get; set; }
    public string title { get; set; }
}

public class To
{
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }
}

public class Trailer
{
    public string youtube_id { get; set; }
    public string url { get; set; }
    public string embed_url { get; set; }
    public Images images { get; set; }
}

public class Webp
{
    public string image_url { get; set; }
    public string small_image_url { get; set; }
    public string large_image_url { get; set; }
}

#pragma warning restore CS8618 