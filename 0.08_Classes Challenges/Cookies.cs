using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_Classes_Challenges
{
    class Program
    {

        static void Main(string[] args)
        {
            Cookies MonicaCookies = new Cookies();
            Cookies JonCookies = new Cookies();
            Cookies SamCookies = new Cookies();
            Cookies LucaCookies = new Cookies();

            MonicaCookies.Size = "small";
            MonicaCookies.Type = "Oatmeal";
            MonicaCookies.HowMany = 4;
            MonicaCookies.Rewards = true;

            JonCookies.Size = "small";
            JonCookies.Type = "Sugar";
            JonCookies.HowMany = 2;
            JonCookies.Rewards = false;

            Console.WriteLine();
            Console.Read();
        }


    }
  

   
}
