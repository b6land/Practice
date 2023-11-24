/// <summary>
/// 迷宮模板的測試
/// </summary>
public class MazeTest{
    Adventurer saber = new Saber();
    Adventurer archer = new Archer();

    EasyMaze easyMaze = new EasyMaze();
    DifficultMaze difficultMaze = new DifficultMaze();

    /// <summary>
    /// 執行迷宮測試
    /// </summary>
    public void Run(){
        difficultMaze.Adventure(saber);
        easyMaze.Adventure(saber);
        easyMaze.Adventure(archer);
        difficultMaze.Adventure(saber);
        difficultMaze.Adventure(archer);    
    }
}