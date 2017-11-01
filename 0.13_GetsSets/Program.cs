using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13_GetsSets
{
    class Program
    {
        static void Main(string[] args)


        {
            Employee newEmployee = new Employee();

            Console.WriteLine("Enter Employee Name:");

            newEmployee.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee ID:");
            newEmployee.ID = int.Parse(Console.ReadLine());
            
            Console.WriteLine(($"New Employee {newEmployee.ID} {newEmployee.ID}"));

            //SET work quote
            WorkQuote newSetWorkQuote = new Employee(); 

            Console.WriteLine($"Enter a common quote for {newEmployee.Name}");

            //GET work quote
            Employee newQuote = new Employee();
        
            Console.WriteLine($"{newEmployee.Name}: {newQuote}");
        }
    }
}
       