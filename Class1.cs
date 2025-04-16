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
s

            public static long Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("Факториал нельзя определить для чисел ниже нуля!");

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
        public static double Sqrt(double number)
        {
            if (number < 0)
                throw new ArgumentException("Нельзя вычислить квадртаный корень из отрицательного числа!");
            return Math.Sqrt(number);
        }
    }
}