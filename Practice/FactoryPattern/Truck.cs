/// <summary>
/// 卡車
/// </summary>
public class Truck : Transport
{
    /// <summary>
    /// 運送
    /// </summary>
    public override void Deliver()
    {
        Console.WriteLine("用卡車進行運送");
    }
}