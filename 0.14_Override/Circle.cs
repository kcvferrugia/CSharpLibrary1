using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Circle : Shape
    {
        public void Circle(int length)
        {
            this.Radius = radius;
        }
        public const int radius = (0);
        public int Radius { get; set; }


        public override double Area()
        {
            return Math.PI * (Math.Pow(this.Radius, 2));
           //area of circle: Pi*r^2
        }


    }
}
