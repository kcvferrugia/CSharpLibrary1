using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Triangle : Shape
    {
        //Constructor
        public Triangle(int THeight, int TBase)
        {
            this.THeight = theight;
            this.TBase = tbase
        }

        //Constants
        public const int NUM_SIDES = 3;

        //Properties
        public int THeight { get; set; }
        public int TBase { get; set; }

        //Methods
        public override double Area()
        {
            return ((TBase * THeight) / 2);
        }
    }
}
