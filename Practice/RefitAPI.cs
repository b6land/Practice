using Refit;
/// <summary>
/// 呼叫 Refit API
/// </summary>
public class RefitAPI
{
    /// <summary>
    /// 呼叫範例的 API 介面
    /// </summary>
    public async void Run(){
        var api = RestService.For<IRefitAPI>("https://jsonplaceholder.typicode.com");

        try
        {
            var getPosts = await api.GetPosts();
            foreach (var post in getPosts)
            {
                Console.WriteLine($"Title: {post.Title}, Body: {post.Body}");
            }

            var Response = api.PostPosts(new RequestBody{title = "Anime", body = "Bocchi the Rock"}).Result;
            Console.WriteLine($"ID: {Response.Id}, Title: {Response.Title}, Body: {Response.Body}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

