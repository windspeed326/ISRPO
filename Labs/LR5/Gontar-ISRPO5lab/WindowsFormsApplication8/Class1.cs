using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    internal class Class1
    {
        public static double Add(double a, double b) => a + b;

        public static double Subtract(double a, double b) => a - b;

        public static double Multiply(double a, double b) => a * b;

        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно");
            return a / b;
        }

        public static double Power(double a, double exponent) => Math.Pow(a, exponent);

        public static double SquareRoot(double a)
        {
            if (a < 0)
                throw new ArgumentException("Корень из отрицательного числа невозможен");
            return Math.Sqrt(a);
        }

        public static double Square(double a) => a * a;

        public static double Percent(double value, double percent) => value * percent / 100;

        public static double Reciprocal(double a)
        {
            if (a == 0)
                throw new DivideByZeroException("Обратное число для нуля не существует");
            return 1 / a;
        }

        public static double Negate(double a) => -a;
    }
}
