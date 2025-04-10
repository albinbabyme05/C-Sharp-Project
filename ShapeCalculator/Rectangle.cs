using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width) 
        {
            Length = length;
            Width = width;
        }

        public override void ResultArea()
        {
            Area = Length * Width;
            Console.WriteLine("Area of Rectangle : " + Area);


        }
    }
}
