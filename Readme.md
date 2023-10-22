此專案使用 .Net 7.0 建立。

下載回來以後，可進入 Practice 目錄，呼叫命令列執行 `dotnet run` 命令，即可啟動程式，並輸入數字執行對應功能，輸入 0 離開程式。

測試專案為 Practice.Tests 目錄，可在該目錄下呼叫命令列，執行 `dotnet test` 命令，呼叫單元測試。

數字上的功能分別對應：

1. 字串的壓縮與解壓縮: [字串壓縮 – Lazy Coding](https://b6land.github.io/String_Compression/)。
2. HashSet 的實驗: [Day 5: C# 資料結構: Hashset - iT 邦幫忙](https://ithelp.ithome.com.tw/articles/10322215)
3. Lambda 語法的實作: [Day 10: C# 再寫一次 Lambda - iT 邦幫忙](https://ithelp.ithome.com.tw/articles/10326389)
4. Async/Await 的練習，並以 HttpClient 取代舊的 WebClient: [async 與 await - Huan-Lin 學習筆記](https://www.huanlintalk.com/2016/01/async-and-await.html)
5. 從 RestCountries 網站呼叫 API 取得國家資料，並建立單元測試 (測試時使用 Stub 隔離外部 API):[【Unit Test】Day 3 - 專注於邏輯，隔離與外部的關聯 - 程式隨筆](https://toyo0103.github.io/2017/04/19/【Unit-Test】Day-3-專注於邏輯，隔離與外部的關聯/)
6. 從 Jikan (非官方 MyAnimeList 網站 API) 取得動畫資料，並建立單元測試 (測試時使用 Mock 隔離外部 API): [【Unit Test】Day 4 - Mock - 程式隨筆](https://toyo0103.github.io/2017/04/20/【Unit-Test】Day-4-Mock/)
7. 從 Instagram 呼叫 API，取得使用者公開的資訊，以及最新一則公開貼文，並建立單元測試 (測試時以 `InternalsVisibleTo` 屬性取得被封裝的內部方法): [【Unit Test】Day 5 - 透過InternalsVisibleTo來達成單元測試的外部注入 - 程式隨筆](https://toyo0103.github.io/2017/04/21/【Unit-Test】Day-5-透過InternalsVisibleTo來達成單元測試的外部注入/)