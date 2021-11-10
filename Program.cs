using System;

class Customer
{
    string _firstname;
    string _lastname;

    public Customer(string firstname, string lastname)
    {
        _firstname = firstname;
        _lastname = lastname;
    }

    public string PrintFullName()
    {
        return _firstname + " " + _lastname;
    }

    ~Customer()
    {
        //clean-up code
    }
}
class Program
{
    static void Main()
    {
        Customer c1 = new Customer("Durga", "Ram");
        Console.WriteLine(c1.PrintFullName());
    }
}