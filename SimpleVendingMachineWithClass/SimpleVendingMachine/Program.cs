using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the .NET Soda Vending Machine!" + System.Environment.NewLine + "Each soda is 35 cents.");
            Console.WriteLine("Please type in the amount of change you'd like to insert.");
            var choice = Console.ReadLine();
            Console.WriteLine("You've inserted " + choice + " cents." + " Thanks, here is your soda.");
        }
    }
}
