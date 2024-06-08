/// <summary>
/// 功能表選項
/// </summary>
public enum MenuOption{
    Exit = 0,
    StringCompress = 1,
    HashSetTest = 2,
    LambdaTest = 3,
    AsyncPractice = 4,
    RestCountries = 5,
    Jikan = 6,
    Instagram = 7,
    MazeTest = 8,
    FactoryTest = 9,
    NullConditionOperatorTest = 10,
    SwitchCaseWhenTest = 11,
    PersistenceLayerTest = 12,
    PropertTest = 13,
    RefitTest = 14
}

/// <summary>
/// 功能表動作類別
/// </summary>
public class MenuAction{
    /// <summary>
    /// 執行各種功能
    /// </summary>
    /// <param name="option">選項</param>
    public void ExecuteOption(MenuOption option){
        switch(option){
            case MenuOption.Exit:
                Environment.Exit(0);
                break;
            case MenuOption.StringCompress:
                CallStringCompress();
                break;
            case MenuOption.HashSetTest:
                CallHashsetTest();
                break;
            case MenuOption.LambdaTest:
                CallLambdaTest();
                break;
            case MenuOption.AsyncPractice:
                CallAsyncPractice();
                break;
            case MenuOption.RestCountries:
                CallRestCountries();
                break;
            case MenuOption.Jikan:
                CallJikan();
                break;
            case MenuOption.Instagram:
                CallInstagram();
                break;
            case MenuOption.MazeTest:
                CallMazeTest();
                break;
            case MenuOption.FactoryTest:
                CallFactoryTest();
                break;
            case MenuOption.NullConditionOperatorTest:
                CallNullConditionOperatorTest();
                break;
            case MenuOption.SwitchCaseWhenTest:
                CallSwitchCaseWhenTest();
                break;
            case MenuOption.PersistenceLayerTest:
                CallPersistenceLayerTest();
                break;
            case MenuOption.PropertTest:
                CallPropertyTest();
                break;
            case MenuOption.RefitTest:
                CallRefitTest();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 測試字串壓縮
    /// </summary>
    public void CallStringCompress(){
        Console.WriteLine("請輸入要壓縮的字串:");
        string? input = Console.ReadLine();

        if(input != null){
            StrGZip sZip = new StrGZip();
            StrGZipBase64 sZip64 = new StrGZipBase64();

            byte[] zipped = sZip.Zip(input);
            string strZipped = sZip.ToHexString(zipped);
            Console.WriteLine("Hex: " + strZipped);
            string unzipped = sZip.Unzip(sZip.StringToByteArray(strZipped));
            Console.WriteLine("已還原: " + unzipped);

            string zippedBase64 = sZip64.compress(input);
            Console.WriteLine("Base64: " + zippedBase64);
            Console.WriteLine("已還原: " + sZip64.decompress(zippedBase64));
        }
    }

    /// <summary>
    /// 測試 HashSet 特性
    /// </summary>
    public void CallHashsetTest(){
        HashSetTest hashSetTest = new HashSetTest();
        hashSetTest.Run();
    }

    /// <summary>
    /// 測試 Lambda 語法
    /// </summary>
    public void CallLambdaTest(){
        LambdaTest lambdaTest = new LambdaTest();
        lambdaTest.Run();
    }

    /// <summary>
    /// 實作非同步語法 Async/Await
    /// </summary>
    public void CallAsyncPractice(){
        AsyncPractice asyncPractice = new AsyncPractice();
        asyncPractice.Run();
    }

    /// <summary>
    /// 從 RestCountries.com 呼叫 API
    /// </summary>
    public void CallRestCountries(){
        RestCountries restCountries = new RestCountries();
        restCountries.Run();
    }

    /// <summary>
    /// 從 jikan.moe 呼叫 API
    /// </summary>
    public void CallJikan(){
        Console.WriteLine("請輸入要查詢的動畫 ID: (不輸入時，預設為 47917 - 孤獨搖滾)");
        string? input = Console.ReadLine();
        int.TryParse(input, out int animeId);

        Jikan jiKan = new Jikan(new MyHttpClient(), animeId);
        jiKan.Run();
    }

    /// <summary>
    /// 從 Instagram 呼叫 API
    /// </summary>
    public void CallInstagram(){
        Instagram ig = new Instagram();
        ig.Run();
    }

    /// <summary>
    /// 呼叫 MazeTemplate 的測試方法
    /// </summary>
    public void CallMazeTest(){
        MazeTest mazeTest = new MazeTest();
        mazeTest.Run();
    }

    /// <summary>
    /// 呼叫 FactoryTest 的測試方法
    /// </summary>
    public void CallFactoryTest(){
        FactoryTest factoryTest = new FactoryTest();
        factoryTest.Run();
    }

    /// <summary>
    /// 呼叫 NullConditionOperatorTest 類別的測試方法
    /// </summary>
    public void CallNullConditionOperatorTest(){
        NullConditionOperatorTest nullTest = new NullConditionOperatorTest();
        nullTest.Run();
    }

    /// <summary>
    /// 呼叫 SwitchCaseWhenTest 類別的測試方法
    /// </summary>
    public void CallSwitchCaseWhenTest(){
        SwitchCaseWhenTest switchCaseWhenTest = new SwitchCaseWhenTest();
        switchCaseWhenTest.Run();
    }

    /// <summary>
    /// 呼叫 PersistanceLayerTest 類別的測試方法，實作 Persistence Layer 的映射，並回傳至 Service Layer
    /// </summary>
    public void CallPersistenceLayerTest(){
        PersistenceLayerTest persistenceLayerTest = new PersistenceLayerTest();
        persistenceLayerTest.Run();
    }

    /// <summary>
    /// 呼叫 PropertyTest 類別的測試方法
    /// </summary>
    public void CallPropertyTest(){
        PropertTest propertTest = new PropertTest();
        propertTest.Run();
    }

    /// <summary>
    /// 呼叫 RefitAPI 類別的測試方法
    /// </summary>
    public void CallRefitTest(){
        RefitAPI refitTest = new RefitAPI();
        refitTest.Run();
    }
}