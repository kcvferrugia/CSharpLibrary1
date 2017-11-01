using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //WET CODE - expanded (less efficient)

            //Student jayStudent = new Student();
            //jayStudent.FirstName = "Jay";
            //jayStudent.LastANme = "Jackson";
            //jayStudent.Grade = 1;
            //jayStudent.Age = 5;

            //DRY CODE - condensed (more efficient)

            //CONSTRUCTOR-same as above just in one line
            //Student jayStudent = new Student("Jay", "Jackson", 5, 1);
            // Student paulStudent = new Student("Paul", "Jackson", 1);
            //Student kendreaStudent = new Student("Kendrea");

            //BRONZE
           
            Challenges myChallenges = new Challenges("iphone", 7);

          

                Console.WriteLine($"I have an  ", (myChallenges));
                Console.ReadLine();
            }
        }
    }
}
