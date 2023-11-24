/// <summary>
/// 簡單迷宮
/// </summary>
public class EasyMaze : MazeTemplate
{
    public EasyMaze(){
        difficulty = 1;
        isHiddenMaze = false;
    }

    /// <summary>
    /// 建立迷宮 (簡單)
    /// </summary>
    public override void CreateMaze()
    {
        Console.WriteLine("建立 100 * 100 的簡單迷宮");
    }

    /// <summary>
    /// 開始冒險
    /// </summary>
    public override void Start()
    {
        Console.WriteLine("冒險者開始進行簡單迷宮的冒險");
    }
}