public class HashSetTest{
    protected class MyName{
        string First;
        string Second;

        public MyName(string f, string s){
            First = f;
            Second = s;
        }

        public string Output(){
            return First + ", " + Second;
        }
    }

    HashSet<int> intHashSet;
    HashSet<MyName> myNameHashSet;

    public HashSetTest(){
        intHashSet = new HashSet<int>();
        myNameHashSet = new HashSet<MyName>();
    }

    public void Run(){
        intHashSet.Add(1);
        intHashSet.Add(2);
        intHashSet.Add(3);
        intHashSet.Add(2); // 重複的值不會再被加進去

        foreach(int v in intHashSet){
            Console.WriteLine(v.ToString());
        }

        MyName LeeYan = new MyName("Lee", "Yan");
        myNameHashSet.Add(new MyName("Wang", "Ming"));
        myNameHashSet.Add(LeeYan);
        myNameHashSet.Add(new MyName("Lin", "Qin"));
        myNameHashSet.Add(new MyName("Wang", "Ming")); // 不同物件 (雖然有相同的值)，會被加進去
        myNameHashSet.Add(LeeYan); // 相同物件不會被加進去

        foreach(MyName v in myNameHashSet){
            Console.WriteLine(v.Output());
        }
    }
}