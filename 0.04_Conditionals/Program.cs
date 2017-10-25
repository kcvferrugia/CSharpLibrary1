using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you feeling today from 1-5?");
            string feelingNumber = Console.ReadLine();

            // if else 
            if (feelingNumber == "5")
            {
                Console.WriteLine("That's great to hear!");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Good stuff!");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("Hope things get better!");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("Oh. Sorry to hear that.");
            }
            else if (feelingNumber == "1")
            {
                Console.WriteLine("Dang. We hope your day gets better!");
            }
            else
            {
                Console.WriteLine("Sorry, we don't understand. Come back later.");
            }

            // Bank Exercise
            var bankAccount = 10000;
            var debt = 4200;
            var difference = bankAccount - debt;

            Console.WriteLine($"I have {bankAccount} in my bank account, and I am {debt} in debt.");

            if (difference >= 700 && difference <= 1999)
            {
                Console.WriteLine("I have extra money. I should pay off my debt. I'll have $" + difference + " left.");
            }
            else if ((bankAccount - debt > 2000))
            {
                Console.WriteLine("I have a ton of extra cash right now. I think I could go to Europe!");
            }
            else
            {
                Console.WriteLine("It probably isn't a good time to pay off my debt.");
            }

        }
    }
}
