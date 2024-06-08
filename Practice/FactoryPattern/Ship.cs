/// <summary>
/// 船類別
/// </summary>
public class Ship : Transport
{
    /// <summary>
    /// 運送
    /// </summary>
    public override void Deliver()
    {
        Console.WriteLine("用船進行運送");
    }
}