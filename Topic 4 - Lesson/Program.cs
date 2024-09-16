using System.ComponentModel.DataAnnotations;

namespace Topic_4___Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String userName;
            int age;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter username");
            userName = Console.ReadLine();
            Console.Write("Your username is " + userName);
            Console.WriteLine("Andre");
            Console.ReadLine();
            Console.WriteLine("Enter your age.");
            Console.WriteLine (Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Your age is " + age);
            Console.ReadLine();
        }
        
    }
}
