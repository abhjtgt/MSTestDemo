using System;

namespace MathDemo
{
    /// <summary>
    /// Common math helpers: sum, minus, multiple and divide.
    /// </summary>
    public static class MathWorks
    {
        /// <summary>
        /// Adds two double values.
        /// </summary>
        public static double Sum(double a, double b) => a + b;

        /// <summary>
        /// Adds two integer values.
        /// </summary>
        public static int Sum(int a, int b) => a + b;

        /// <summary>
        /// Subtracts <paramref name="b"/> from <paramref name="a"/> (double).
        /// </summary>
        public static double Minus(double a, double b) => a - b;

        /// <summary>
        /// Subtracts <paramref name="b"/> from <paramref name="a"/> (int).
        /// </summary>
        public static int Minus(int a, int b) => a - b;

        /// <summary>
        /// Multiplies two double values.
        /// </summary>
        public static double Multiple(double a, double b) => a * b;

        /// <summary>
        /// Multiplies two integer values.
        /// </summary>
        public static int Multiple(int a, int b) => a * b;

        /// <summary>
        /// Divides two double values. Throws <see cref="DivideByZeroException"/> if <paramref name="b"/> is zero.
        /// </summary>
        public static double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }

            return a / b;
        }

        /// <summary>
        /// Divides two integer values and returns a double. Throws <see cref="DivideByZeroException"/> if <paramref name="b"/> is zero.
        /// </summary>
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }

            return (double)a / b;
        }
    }
}