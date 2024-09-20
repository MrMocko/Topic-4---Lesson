using Microsoft.Win32.SafeHandles;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

namespace Topic_4___Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Andre
            string userName, pizzatop, name;
            int age;
            double price;
            double di;
            double rad;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Enter username");
            userName = Console.ReadLine();
            Console.Write("Your username is: " + userName);
            Console.WriteLine("");
            Thread.Sleep(750);
            Console.WriteLine("Enter your age.");
            Console.WriteLine (Int32.TryParse(Console.ReadLine(), out age));
            Console.WriteLine("Your age is " + age);
            Console.ReadLine();
            Console.WriteLine("What is the price");
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("The price is " + (price * 0.8).ToString("C"));
            Console.ReadLine();
            Console.WriteLine("What's up man, whats your name? ");
            name = Console.ReadLine();
            Console.WriteLine("OHHHHHHH NO WAYYYYYY IT'S REALY YOU " + name );
            Thread.Sleep(2000);
            Console.WriteLine("Wait whats your fav toping on pizza again?" );
            pizzatop = Console.ReadLine();
            Console.WriteLine("NO WAY " + pizzatop + " IS MY FAV TOO");
            Thread.Sleep(1000);
            Double.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("Hey man could you give me a random number for the diameter of a circle");
            Console.WriteLine(Double.TryParse(Console.ReadLine(), out di));
            Console.WriteLine("Woowza man the radius of that circle is pretty cool, i didnt know that it is " + (di / 2));
        }
        
    }
}
