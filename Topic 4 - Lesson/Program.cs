using System.ComponentModel.DataAnnotations;

namespace Topic_4___Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Andre
            string userName;
            int age;
            double price;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter username");
            userName = Console.ReadLine();
            Console.Write("Your username is: " + userName);
            Console.WriteLine("");
            Console.ReadLine();
            Console.WriteLine("Enter your age.");
            Console.WriteLine (Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Your age is " + age);
            Console.ReadLine();
            Console.WriteLine("What is the price");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The price is " + (price * 0.8).ToString("C"));
        }
        
    }
}
