using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8
{
    internal class Class2
    {
        public static double Sin(double angle, bool isRadians = false)
        {
            double angleInRadians = isRadians ? angle : DegreesToRadians(angle);
            return Math.Round(Math.Sin(angleInRadians), 10);
        }

        public static double Cos(double angle, bool isRadians = false)
        {
            double angleInRadians = isRadians ? angle : DegreesToRadians(angle);
            return Math.Round(Math.Cos(angleInRadians), 10);
        }

        public static double Tan(double angle, bool isRadians = false)
        {
            double angleInRadians = isRadians ? angle : DegreesToRadians(angle);
            return Math.Round(Math.Tan(angleInRadians), 10);
        }

        public static double Cot(double angle, bool isRadians = false)
        {
            double tanValue = Tan(angle, isRadians);
            if (tanValue == 0)
                throw new DivideByZeroException("Котангенс не существует для данного угла");
            return 1 / tanValue;
        }

        public static double Asin(double value)
        {
            if (value < -1 || value > 1)
                throw new ArgumentException("Аргумент должен быть в диапазоне [-1, 1]");
            return Math.Asin(value);
        }

        public static double Acos(double value)
        {
            if (value < -1 || value > 1)
                throw new ArgumentException("Аргумент должен быть в диапазоне [-1, 1]");
            return Math.Acos(value);
        }

        public static double Atan(double value) => Math.Atan(value);

        public static double Sinh(double angle) => Math.Sinh(angle);

        public static double Cosh(double angle) => Math.Cosh(angle);

        public static double Tanh(double angle) => Math.Tanh(angle);

        public static double DegreesToRadians(double degrees) => degrees * Math.PI / 180;

        public static double RadiansToDegrees(double radians) => radians * 180 / Math.PI;
    }
}
