using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_with_operator
{
    public abstract class Calcualtor
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        //constructor
        public Calcualtor(double number1, double number2)
        {
            Number1 = number1;
            Number2 = number2;
        }

        //methods

        public abstract double Addition(double number1, double number2);
        public abstract double Substraction(double number1, double number2);
        public abstract double Multiplication(double number1, double number2);
        public abstract double Division(double number1, double number2);



    }
}
