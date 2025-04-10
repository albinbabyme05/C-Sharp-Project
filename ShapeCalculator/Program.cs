

namespace ShapeCalculator
{
    class Program
    {

        static void Main(string[] args)
        {
            //create an instance of the class of recta ngle
            Shape s1 = new Rectangle(10, 5);
            s1.ResultArea();

            // triangle
            Shape s2 = new Triangle(10, 5);
            s2.ResultArea();



        }
    }
}

