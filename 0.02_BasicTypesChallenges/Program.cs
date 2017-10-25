using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //BRONZE
            int luckyNumber;
            string firstName = "Jay";
            string lastName = "Jackson";
            bool isMarried = false;
            double Pi = 3.14;

            Console.WriteLine(Pi);
            Console.WriteLine(isMarried);

            //SILVER
            string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);

            //GOLD
            string birthYear = "1980";
            int year = Convert.ToInt32(birthYear);

            string age = "30";
            int numAge = Convert.ToInt32(age);
            numAge = numAge + 1;

            Console.WriteLine(numAge);



            //Console.WriteLine("I was born in " + year);


        }
    }
}
