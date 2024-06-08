/// <summary>
/// 物流類別
/// </summary>
public abstract class Logistics
{
    protected Transport? product;

    /// <summary>
    /// 產生運送的物件
    /// </summary>
    public abstract void FactoryMethod();

    /// <summary>
    /// 運送
    /// </summary>
    public void RunDeliver()
    {
        if(product != null){
            product.Deliver();
        }
        else{
            Console.WriteLine("沒有產生運送方式");
        }
    }
}