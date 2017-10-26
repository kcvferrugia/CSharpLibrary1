using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Solutions
{
    class Program
    {
        static void Main(string[] args)

            //ASSIGNING OBJECT VALUES
        {
            Netflix theOffice = new Netflix();
            Netflix strangerThings = new Netflix();
            Netflix theItCrowd = new Netflix();

            theOffice.Name = "The Office";
            theOffice.Genre = "Comedy";
            theOffice.Rating = 5.0;

            strangerThings.Name = "Stranger Things";
            strangerThings.Genre = "Horror";
            strangerThings.Rating = 4.6;

            theItCrowd.Name = "The IT Crowd";
            theItCrowd.Genre = "Comedy";
            theItCrowd.Rating = 1.5;

            //CALLING the METHODS (invoking, executing functions/methods)

            theOffice.GetSuggestion();
            strangerThings.GetSuggestion();
            theItCrowd.GetSuggestion();

            //Create objects for Netflix classes
            List<Netflix> favoriteShows = new List<Netflix>();

            favoriteShows.Add(theOffice);
            favoriteShows.Add(strangerThings);
            favoriteShows.Add(theItCrowd);

            foreach (Netflix show in favoriteShows)
            {
                Console.WriteLine(show.Name);
                
                // ... Join strings into a single string.

                string joined = string.Join("|", show.Name);
                Console.WriteLine(joined);

            }
            Console.ReadLine();
        }
    }
}