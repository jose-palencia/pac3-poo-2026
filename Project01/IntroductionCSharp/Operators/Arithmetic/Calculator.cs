namespace Project01.IntroductionCSharp.Operators.Arithmetic
{
    public class Calculator
    {
        public int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtract(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }

        public double Divide(int n1, int n2)
        {
            return (double)n1 / (double)n2; //cast
        }

        public double Pi()
        {
            return 3.14189;
        }

        public double Module(double n1, double n2)
        {
            return n1 % n2;
        }
    }
}