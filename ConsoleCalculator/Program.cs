namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            


            CalculatorBrain calc = new();

        }

        static double? Calculate(CalculatorBrain calc, int function, double input1, double input2)
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
