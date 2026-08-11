using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if(num % 2 == 0)
        {
            Console.WriteLine("The number is even");
        }
    }
}
