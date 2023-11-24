/// <summary>
/// 冒險者類別
/// </summary>
public abstract class Adventurer
{
    /// <summary>
    /// 冒險者等級
    /// </summary>
    public int level {get; set;}
    
    /// <summary>
    /// 冒險者類型
    /// </summary>
    public string? adventurerType {get; protected set;}

    
}