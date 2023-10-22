using System.Net;


public class Instagram{
    InstagramDTO? _igDTO;

    IHttpClient _httpClient{
        get{
            return IHttpClientFactory.Create();
        }
    }

    /// <summary>
    /// 以非同步方式下載 IG 資料
    /// </summary>
    public async void Run(){
        string url = @"https://www.instagram.com/keelungtravel/?__a=1&__d=dis";
        string responseBody = await _httpClient.GetResponseBody(url);
        _igDTO = GetInstagramInfo(responseBody);

        Console.WriteLine("API 資料:");
        if (_igDTO != null)
        {
            Console.WriteLine($"名稱: {_igDTO.full_name}");
            Console.WriteLine($"ID: {_igDTO.id}");
            Console.WriteLine($"個人資料: {_igDTO.biography}");
            Console.WriteLine($"最新一篇貼文內容: {_igDTO.first_edge_caption}");
        }
    }
    
    /// <summary>
    /// 從 JSON 取得 IG 資料
    /// </summary>
    /// <param name="body"> 含 IG 資料的 JSON 字串 </param>
    /// <returns> InstagramDTO 物件 </returns>
    public InstagramDTO? GetInstagramInfo(string body){
        InstagramResult igResult = new InstagramResult();
        InstagramResult.Root? deserializedIg = igResult.GetInstagramResult(body);

        if (deserializedIg != null){
            InstagramDTO igDTO = new InstagramDTO(){
                biography = deserializedIg.graphql.user.biography,
                full_name = deserializedIg.graphql.user.full_name,
                id = deserializedIg.graphql.user.id
            };

            if(deserializedIg.graphql.user.edge_owner_to_timeline_media.edges.Count > 0){
                List<InstagramResult.Edge>? edges = deserializedIg.graphql.user.edge_owner_to_timeline_media.edges;
                if(edges[0].node.edge_media_to_caption.edges.Count > 0){
                    igDTO.first_edge_caption = edges[0].node.edge_media_to_caption.edges[0].node.text;
                }
                
            }

            return igDTO;
        }
        
        return null;
    }
}