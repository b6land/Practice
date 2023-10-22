internal class IHttpClientFactory{

    internal static IHttpClient _httpClient;
    
    /// <summary>
    /// 取得實體
    /// </summary>
    /// <returns> MyHttpClient 實體 </returns>
    internal static IHttpClient Create(){
        if(_httpClient == null){
            _httpClient = new MyHttpClient();
        }
        return _httpClient;
    }
}