/// <summary>
/// 陸上物流
/// </summary>
public class RoadLogistics : Logistics
{
    /// <summary>
    /// 產生運送的物件
    /// </summary>
    public override void FactoryMethod()
    {
        product = new Truck();
    }
}