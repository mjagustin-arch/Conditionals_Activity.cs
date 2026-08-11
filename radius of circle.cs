using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the area of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Choose if 'A' is for area, 'P' for perimeter, and 'X' for exit: ");
        char choice = Convert.ToChar(Console.ReadLine());

        switch (choice)
        {
            case 'A':
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Area = {area}");
            break;

            case 'P':
            double perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Parameter: {perimeter}");
            break;

            case 'X':
            Console.WriteLine("Exit the Application");
            break;

            default:
            Console.WriteLine("Error");
            break;

        }
    }
}
