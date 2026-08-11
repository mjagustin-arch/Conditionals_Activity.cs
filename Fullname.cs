using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first name: ");
        string first = Console.ReadLine();
        Console.WriteLine("Enter your last name: ");
        string last = Console.ReadLine();

        string fullname = first + " " + last;

        Console.WriteLine(fullname);

    }
}
