using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Solutions
{
    class Netflix
    {
        //Prorperties
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        
      
        //Methods
        public void GetSuggestion()
        {
            Console.WriteLine("You should watch!" + this.Name);
            Console.Read();
            {
                if (this.Rating > 3.5)
                {
                    Console.WriteLine("This is a pretty good show."); 
                }
                else
                {
                    Console.WriteLine("Don't watch");
                }
            }

         








            Console.Read();
        }
            
       
        









    }
}