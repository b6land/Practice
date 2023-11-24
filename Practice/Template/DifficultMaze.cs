/// <summary>
/// 困難迷宮類別
/// </summary>
public class DifficultMaze : MazeTemplate
{
    public DifficultMaze(){
        difficulty = 50;
        isHiddenMaze = true;
    }

    /// <summary>
    /// 建立迷宮 (困難)
    /// </summary>
    public override void CreateMaze()
    {
        Console.WriteLine("建立 1000 * 1000 的困難迷宮");
    }

    /// <summary>
    /// 開始冒險
    /// </summary>
    public override void Start()
    {
        Console.WriteLine("冒險者開始進行困難迷宮的冒險");
    }
}