using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class QuizAnswerone : Shape
    { 
        //Constructor
        public Triangle(int theight, int tbase)
        {
            this.THeight = theight;
            this.TBase = tbase;
        }

        //Constants
        public const int NUM_SIDES = 3;

        //Properties
        public int THeight { get; set; }
        public int TBase { get; set; }
        public int TArea { get; set; }

        //Methods
        public override double Area()
        {
            this.TArea = this.TBase * this.THeight / 2;//or 2.0: to return decimal
            return this.TArea;
        }
    }
}
    

