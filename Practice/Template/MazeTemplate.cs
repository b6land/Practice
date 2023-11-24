/// <summary>
/// 迷宮模板
/// </summary>
public abstract class MazeTemplate{
    protected int difficulty;
    protected Adventurer? adventurer;
    protected bool isHiddenMaze;
    
    /// <summary>
    /// 開始冒險
    /// </summary>
    /// <param name="adventurer"> 冒險者 </param>
    /// <returns> 冒險完的冒險者 </returns>
    public Adventurer Adventure(Adventurer adventurer){
        this.adventurer = adventurer;

        if(CheckLevel(adventurer.level) == false){
            Console.WriteLine(adventurer.adventurerType + " 等級不夠，請提升至 " + difficulty + " 級以上，才開放迷宮");
        }
        else{
            Console.WriteLine(adventurer.adventurerType + " 開始進行困難度 " + difficulty + " 的迷宮");
            CreateMaze();            
            Start();

            if(isHiddenMaze){
                GoHiddenMaze();
            }

            Finish();
        }

        return adventurer;
    }

    /// <summary>
    /// 檢查冒險者等級是否滿足難度要求
    /// </summary>
    /// <param name="level"> 等級 </param>
    /// <returns> 是否滿足 </returns>
    private bool CheckLevel(int level){
        return level >= difficulty;
    }

    public abstract void CreateMaze();

    public abstract void Start();

    /// <summary>
    /// 進入隱藏迷宮
    /// </summary>
    void GoHiddenMaze(){
        Console.WriteLine("進入隱藏迷宮");
    }

    /// <summary>
    /// 完成迷宮
    /// </summary>
    /// <returns> 冒險完的冒險者 </returns>
    Adventurer? Finish(){
        if(adventurer != null){
            this.adventurer.level = this.adventurer.level + 50 * difficulty;
            Console.WriteLine(adventurer.adventurerType + " 完成困難度 " + difficulty + " 迷宮！");
        }
        
        return adventurer;
    }
}