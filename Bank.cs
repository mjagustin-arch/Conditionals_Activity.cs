using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Principal Ammount: ");
        int principal = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Rate of Interest: ");
        int interest = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Time (in years): ");
        int time = Convert.ToInt32(Console.ReadLine());

        int formula = (principal * interest * time)/100;

        Console.WriteLine("Simple Interest: " + formula);
    }
}
