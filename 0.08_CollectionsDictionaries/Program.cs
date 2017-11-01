using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)

            //basic structure
        {
            Dictionary<string, string> movieList = new Dictionary<string, string>();

            movieList.Add("2000", "American Beauty"),
            movieList.Add("2001", "Gladiator"),
            movieList.Add("2002", "Beautiful Mind"),
            movieList.Add("Chicago", "2003");
            movieList.Add("Lord of the Rings: The Return of the King", "2004");
            movieList.Add("Million Dollar Baby", "2005")

            // Read all data
            Console.WriteLine("Movie List");

            foreach (var > movie in movieList)
            {
                Console.WriteLine($"{movielist.Key} in {movielist.Value});
            }

            Console.ReadKey();

        }
    }
}
 

       
  
