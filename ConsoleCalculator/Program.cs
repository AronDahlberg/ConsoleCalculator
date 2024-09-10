using System.Reflection.Metadata.Ecma335;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculatorBrain calc = new();
            double[] input;
            double? output;
            bool close = false;

            while (!close)
            {
                input = MenuSelect();

                output = Calculate(calc, input[0], input[1], input[2]);

                Console.WriteLine("output: " + output);

                Console.WriteLine("input 'e' to exit or enter to restart:");

                if (Console.ReadLine() == "e")
                {
                    close = true;
                }
            }

            Console.Clear();
        }

        static double[] MenuSelect()
        {
            double[] output = new double[3];
            double function;
            double input1;
            double input2;

            Console.Clear();

            Console.WriteLine("Input 1, 2, 3, or 4 to select either\n" +
                "addition, subtraction, multiplication, or division:");
            while (!double.TryParse(Console.ReadLine(), out function)) ;

            Console.WriteLine("Input first input number:");
            while (!double.TryParse(Console.ReadLine(), out input1)) ;

            Console.WriteLine("Input second input number:");
            while (!double.TryParse(Console.ReadLine(),out input2)) ;

            output[0] = function;
            output[1] = input1;
            output[2] = input2;

            return output;
        }
        static double? Calculate(CalculatorBrain calc, double function, double input1, double input2)
        {
            double? output;

            switch (function)
            {
                case 1: output = calc.Addition(input1, input2); break;

                case 2: output = calc.Subtraction(input1, input2); break;

                case 3: output = calc.Multiplication(input1, input2); break;

                case 4: output = calc.Division(input1, input2); break;

                default: output = null; break;
            }

            return output;
        }
    }
}
