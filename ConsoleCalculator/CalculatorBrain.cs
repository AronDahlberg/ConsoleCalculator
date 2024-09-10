namespace ConsoleCalculator
{
    internal class CalculatorBrain
    {
        public CalculatorBrain()
        {

        }

        public int Addition(int value1, int value2)
        {
            return value1 + value2;
        } 

        public int Subtraction(int value1, int value2)
        {
            return value1 - value2;
        }

        public int Multiplication(int value1, int value2)
        {
            return value1 * value2;
        }

        public double Division(int value1, int value2)
        {
            return value1 / value2;
        }
    }
}
