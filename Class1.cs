using System;

namespace mathFunc
{
    public static class MathFunctions
    {
        public static double Plus(double a, double b) => a + b;

        public static double Subtraction(double a, double b) => a - b;

        public static double Module(double a) => Math.Abs(a);

        public static double Cosinus(double a) => Math.Cos(a);

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Попытка деления на ноль!");
            return a / b;
        }
        public static double Sinus(double a) => Math.Sin(a);

    }
}