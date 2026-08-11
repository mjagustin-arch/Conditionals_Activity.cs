using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num >= 1)
        {
            Console.WriteLine($"The{num} is positive");
        }

        else
        {
            Console.WriteLine($"The {num} is negative");
        }
    }
}
