using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

        Fraction f1 = new Fraction(5);
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(3,4);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        // // Account savings = new Account();
        // // savings._balance = 50;
        // // savings.Deposit(100);;

        // // if we change it to  list
        // Account savings = new Account();//this is an instance
        // // savings._balance = 50; //this approach won't work anymore
        // savings.Deposit(100); //this approach would continue to work

        // // int money = savings.GetBalance();

        // Person p = new Person(); // this is an instance of a constructor... i think
        // p.SetFirstName("Peter");
        // Console.WriteLine(p.GetFirstName());

        // Person p1 = new Person(); // don't pass any information to get the default value
        // Person p2 = new Person("Jane", "Doe"); //pass the first n last names
        // Person p3 = new Person("Mrs.","Jane","Doe");//pass all three variables
        // // focus on waht the calss must do rather than how it will do
    }
}