using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    public class Shape
    {
        public double Area { get; set; }

        public Shape()
        {
            Area = 0;
        }

        public virtual void ResultArea()
        {
            Console.WriteLine("Area : " +Area);
        }
    }
}
