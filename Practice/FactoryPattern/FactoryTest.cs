/// <summary>
/// 工廠模式測試類別
/// </summary>
public class FactoryTest{
    /// <summary>
    /// 執行工廠模式測試
    /// </summary>
    /// <remarks> 參考資料：https://ithelp.ithome.com.tw/articles/10217120 </remarks>
    public void Run(){
        Logistics logistics = new RoadLogistics();
        logistics.FactoryMethod();
        logistics.RunDeliver();

        logistics = new SeaLogistics();
        logistics.FactoryMethod();
        logistics.RunDeliver();
    }
}