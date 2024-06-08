using Refit;

/// <summary>
/// 呼叫 Refit API
/// </summary>
public interface IRefitAPI{
    [Get("/posts")]
    Task<List<Post>> GetPosts();

    [Post("/posts")]
    Task<Post> PostPosts(RequestBody req);
}

/// <summary>
/// Post 資料物件
/// </summary>
public class Post
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Body { get; set; }
}

/// <summary>
/// 請求內文
/// </summary>
public class RequestBody
{
    public string? title { get; set; }
    public string? body { get; set; }
}