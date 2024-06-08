public class SwitchCaseWhenTest{

    /// <summary>
    /// 測試用動物類別
    /// </summary>
    public class Animal{
        public string? name { get; set; }
        public bool isFly {get; set; }
        public bool isWalk {get; set; }
    }

    /// <summary>
    /// 測試 Switch...Case...When 的使用方式
    /// </summary>
    public void Run(){

        Animal dog = new Animal {name = "狗", isFly = false, isWalk = true};
        ShowBySwitch(dog);
        Animal goose = new Animal {name = "鵝", isFly = true, isWalk = true};
        ShowBySwitch(goose);
        Animal bird = new Animal {name = "鳥", isFly = true, isWalk = false};
        ShowBySwitch(bird);
        Animal fish = new Animal {name = "魚", isFly = false, isWalk = false};
        ShowBySwitch(fish);
    }


    /// <summary>
    /// 用 switch 判斷是否可以飛和走路，並顯示在命令列
    /// </summary>
    private void ShowBySwitch(Animal a){
        switch(a.isWalk){
            case true when a.isFly == false:
                Console.WriteLine(a.name + "可以走路，但不能飛");
                break;
            case true when a.isFly == true:
                Console.WriteLine(a.name + "可以走路，也可以飛");
                break;
            case false when a.isFly == true:
                Console.WriteLine(a.name + "不能走，但可以飛");
                break;
            case false when a.isFly == false:
                Console.WriteLine(a.name + "不能走，也不能飛");
                break;
        }
    }
}