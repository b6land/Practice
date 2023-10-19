using System.Net;

/// <summary>
/// 非同步程式測試
/// </summary>
public class AsyncPractice{
        /// <summary>
    /// 非同步執行
    /// </summary>
    public async void Run(){
        
        string url = "https://b6land.github.io/";
        var downloader = await DownloadPage(url); // 以 await 呼叫，會先跳出 Run() 執行其它方法 (若有的話)，直到 DownloadPage(url) 執行完成，才繼續往下執行

        string content = downloader;
        Console.WriteLine(content.Substring(0, 100));

        string urlMsn = "https://msn.com/";
        var downloaderMsn = DownloadPage(urlMsn); // 沒有 await 時，程式會往下執行

        string urlYahoo = "https://tw.yahoo.com/";
        var downloaderYahoo = DownloadPage(urlYahoo); 
        
        string contentYahoo = downloaderYahoo.Result; // 阻擋，程式執行到此處停住，直到 DownloadPage(urlYahoo) 執行完成，才繼續往下執行
        Console.WriteLine(contentYahoo.Substring(0, 100));

        string contentMsn = downloaderMsn.Result; 
        Console.WriteLine(contentMsn.Substring(0, 100));
    }

    /// <summary>
    /// 以非同步方式下載網頁內容
    /// </summary>
    /// <param name="url"> 網址 </param>
    /// <returns> 網頁內容字串 </returns>
    private async Task<string> DownloadPage(string url){
        HttpClient client = new HttpClient();
        string content = await client.GetStringAsync(url);
        Console.WriteLine("Download finished: " + url);
        return content;
    }
}