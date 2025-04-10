using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_operator
{
    public class Operations : Calcualtor 
    {
        public Operations(double number1, double number2):base(number1, number2)
        {
            
        }
        public override double Addition(double number1, double number2)
        {
            return number1 + number2;
        }

        public override double Substraction(double number1, double number2)
        {
            return number1 - number2;
        }

        public override double Multiplication(double number1, double number2)
        {
            return number1 * number2;
        }

        public override double Division(double number1, double number2)
        {
            if(number2 != 0)
            {
                return number1 / number2;
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not possible 😔");
                return 0;
            }

        }

       
    }
}
