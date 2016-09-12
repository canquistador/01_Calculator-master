using System;
namespace _01_Calculator
{
    public class Calculator
    {

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;

        }

        public static int Sum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;

        }


        public static double Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error, can't divide with 0!");
            }
            return a / b;
        }


        public static int Multy(int a, int b)
        {
            return a * b;
        }

        public static int Multy(int[] numbers2)
        {
            int sol = 1;
            for (int i = 0; i < numbers2.Length; i++)
            {
                sol *= numbers2[i];
            }

            return sol;
        }

        public static double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public static double Fac(double a)
        {
            if (a == 0)
            {
                return 1;
            }

            double result = 1;

            for (double i = a; i > 0; i--)
            {
                result *= i;
            }

            return result;

        }

    }

}