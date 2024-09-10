namespace ConsoleCalculator
{
    internal class CalculatorBrain
    {
        public double? Calculate(int function, double input1, double input2)
        {
            double? output;

            switch(function)
            {
                case 1: output = Addition(input1, input2); break;

                case 2: output = Subtraction(input1, input2); break;

                case 3: output = Multiplication(input1, input2); break;

                case 4: output = Division(input1, input2); break;

                default: output = null; break;
            }

            return output; 
        }

        public double Addition(double value1, double value2)
        {
            return value1 + value2;
        } 

        public double Subtraction(double value1, double value2)
        {
            return value1 - value2;
        }

        public double Multiplication(double value1, double value2)
        {
            return value1 * value2;
        }

        public double Division(double value1, double value2)
        {
            return value1 / value2;
        }
    }
}
