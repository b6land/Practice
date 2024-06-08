public class NullConditionOperatorTest
{
    /// <summary>
    /// 執行 Null 條件運算子的測試
    /// </summary>
    public void Run()
    {
        Car? car = null;
        car?.Name.ToUpper(); // 最後的 Write() 方法不會被執行
        try {
            (car?.Name).ToUpper();    
        }
        catch (NullReferenceException) {
            Console.WriteLine("Null Reference Exception occured");
        }; // 會觸發 Null Reference Exception
    }

    /// <summary>
    /// 測試用車輛類別
    /// </summary>
    public class Car{
        public string? Name {get; set;}
    }
}