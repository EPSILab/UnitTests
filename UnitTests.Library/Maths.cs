using System;

namespace UnitTests.Library
{
    public static class Maths
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Multiplication(double a, double b)
        {
            return a * b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentOutOfRangeException("b","La division par 0 est impossible.");
            }

            return a / b;
        }

        public static double Pow(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}