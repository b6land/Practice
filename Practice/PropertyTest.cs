public class PropertTest
{
    public class Customer
    {
        // private string? _name;
        // private int _money;

        // public string? Name
        // {
        //     get { return _name; }
        //     set { _name = value; }
        // }

        // public int Money
        // {
        //     get { return _money; }
        //     private set
        //     {
        //         if (value < 0) { _money = 0; }
        //         else { _money = value; }
        //     }
        // }

        public string? Name { get; set; }
        public int Money { get; private set; }

        public Customer(string n, int m)
        {
            Name = n;
            Money = m;
        }
    }

    public void Run(){
        Customer c = new Customer("Allen", 100);
        // c.Money = 50;
        Console.WriteLine($"Name: {c.Name}, Money: {c.Money}");

        Customer c2 = new Customer("Bill", -10);
        Console.WriteLine($"Name: {c2.Name}, Money: {c2.Money}");
    }
}

