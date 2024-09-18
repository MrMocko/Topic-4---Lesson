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
            string userName;
            int age;
            double price;
            string pizzatop;
            string name;
            pizzatop = "BRAK";
            name = "Jimmy";
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
            Console.ReadLine();
            Console.WriteLine("What's up man, whats your name? ");
            name = Console.ReadLine();
            Console.WriteLine("OHHHHHHH NO WAYYYYYY IT'S REALY YOU " + name );
            Thread.Sleep(2000);
            Console.WriteLine("Wait whats your fav topng on pizza again?" );
            pizzatop = Console.ReadLine();
            Console.WriteLine("NO WAY " + pizzatop + " IS MY FAV TOO"); 
        }
        
    }
}
