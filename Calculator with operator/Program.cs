

namespace Calculator_with_operator
{
    class Program
    {
        public static void DisplayInfo()
        {
            Console.WriteLine("1.Additon \n 2.Subtraction \n 3.Multiplication \n 4.Division ");
            Console.WriteLine("Enter your choice : ");
        }

        static void Main(string[] args)
        {

            DisplayInfo();
            double choice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the first number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            //create an instance of the object
            Calcualtor op1 = new Operations(num1, num2);

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Result of {num1} + {num2} : {op1.Addition(num1, num2)}");                   
                    break;

                case 2:
                    Console.WriteLine($"Result of {num1} - {num2} : {op1.Substraction(num1, num2)}");
                    break;

                case 3:
                    Console.WriteLine($"Result of {num1} - {num2} : {op1.Multiplication(num1, num2)}");
                    break;

                case 4:
                    Console.WriteLine($"Result of {num1} - {num2} : {op1.Division(num1, num2)}");
                    break;

                default:
                    Console.WriteLine("invalid entry");
                    break;
            }





        }
    }
}

