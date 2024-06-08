/// <summary>
/// 水面物流
/// </summary>
public class SeaLogistics : Logistics
{
    /// <summary>
    /// 產生運送的物件
    /// </summary>
    public override void FactoryMethod()
    {
        product = new Ship();
    }
}