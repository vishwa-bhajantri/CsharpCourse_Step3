using System;

namespace Method_Preparation_in_ShortWay
{
    class Demo

    {
        public static void PrintNumber()
        {
            Console.WriteLine("Number is 10");
        }

        public static int Multiplication(int number)
        {
            return number * number;
        }
    }

    class Program
    {
        static void Main()
        {
            //Demo.PrintNumber();

            //var result2 = Demo.Multiplication(10);
            //Console.WriteLine(result2);

            var PrintNumber = () =>
        {
            Console.WriteLine("Number is 10");
        };
            PrintNumber();

            var Multiplication = (int number) =>
        {
            return number * number;
        };
            Console.WriteLine(Multiplication(2));
        }
    }
}