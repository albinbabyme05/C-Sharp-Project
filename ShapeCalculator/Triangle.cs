using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    internal class Triangle :Shape
    {
        public double Width;
        public double Height;

        public Triangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override void ResultArea()

        {
            Area = (Height * Width) / 2;
            Console.WriteLine("Area of Triangle : " + Area);

        }
    }
}
