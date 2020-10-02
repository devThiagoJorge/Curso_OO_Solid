using System;

namespace Aula_4_Sobrecarga
{
    class Program
    {
        static public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
        static public int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }
        static public double Sum(int num1, double num2)
        {
            return num1 + num2;
        }

        static public int Sum(params int[] numbers)
        {
            var result = 0;

            foreach (var number in numbers)
            {
                result += number;
            }

            return result;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Write Sum 2 params");
            Console.WriteLine(Sum(1,3));
            Console.WriteLine("Write Sum  3 params");
            Console.WriteLine(Sum(1, 2, 3));
            Console.WriteLine("Write Sum double");
            Console.WriteLine(Sum(1, 1.4));
            Console.WriteLine("Write Sum with many params");
            Console.WriteLine(Sum(1,2,3,4,5,6,7,8,9,10));

            Console.WriteLine("This is overload");

        }
    }
}
