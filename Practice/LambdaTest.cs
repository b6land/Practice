public class LambdaTest{
    protected class Receiver{
        public string name;
        public string email;

        public Receiver(string n, string m){
            name = n;
            email = m;
        }
    }

    public void Run(){
        List<Receiver> receiver = new List<Receiver>();

        receiver.Add(new Receiver("Jack", "Jack@gmail.com"));
        receiver.Add(new Receiver("Justin", "Justin@gmail.com"));
        receiver.Add(new Receiver("Eddy", "Eddy@hotmail.com"));
        receiver.Add(new Receiver("Jeff", "Chen.Jeff@gmail.com"));

        int jCount = receiver.Count(n => n.name.StartsWith("J"));
        Console.WriteLine("Receiver start with J:" + jCount);

        IOrderedEnumerable<Receiver> AscReceiver = receiver.OrderBy(n => n.email);
        foreach(Receiver r in AscReceiver){
            Console.WriteLine(r.email + "(" + r.name + ")");
        }

        IOrderedEnumerable<Receiver> DescReceiver = receiver.OrderByDescending(n => n.email);
        foreach(Receiver r in DescReceiver){
            Console.WriteLine(r.email + "(" + r.name + ")");
        }
    }
}