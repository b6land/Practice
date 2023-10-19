MenuAction action = new MenuAction();

while(true){
    foreach(int v in Enum.GetValues<MenuOption>()){
        Console.Write(v + ": " + (MenuOption)v + ", ");
    }

    Console.WriteLine("請輸入想要執行的功能: ");

    string? command = Console.ReadLine();
    if(command != null){
        bool isParsed = Enum.TryParse(command, out MenuOption option);
        if(isParsed){
            action.ExecuteOption(option);
        }
        else{
            Console.WriteLine("請重新輸入適合選項");
        }
    }
}











