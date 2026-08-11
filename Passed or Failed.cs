using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        int passing = 50;

        string result = (score >= passing) ? "passed" : "failed";
        Console.WriteLine(result);
    }
}
